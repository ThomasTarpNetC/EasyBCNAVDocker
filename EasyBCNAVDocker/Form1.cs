﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//BCNAV
using System.Diagnostics;
using System.Management.Automation;

namespace EasyBCNAVDocker
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            lblNotificationTxt.Text = "";
            if (!CheckNAVContainerHelper())
            {
                lblNotificationTxt.Text += "NavContainerHelper is not installed!    ";
                pnlNotification.Visible = true;
            }
            if (!CheckDocker())
            {
                lblNotificationTxt.Text += "Docker is not installed!";
                pnlNotification.Visible = true;
            }
        }

        private void btnCreateContainer_Click(object sender, EventArgs e)
        {
            CreateContainer();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private Boolean CheckNAVContainerHelper()
        {
            Process process = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "powershell.exe",
                Arguments = "/C get-installedmodule navcontainerhelper"
            };
            process.StartInfo = startinfo;
            return (process.Start());
        }

        private Boolean CheckDocker() 
        {
            Process process = new Process();
            ProcessStartInfo startinfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "CMD.exe",
                Arguments = "/C docker -v"
            };
            process.StartInfo = startinfo;
            return(process.Start());
        }

        private void txtBoxDatabase_MouseDown(object sender, MouseEventArgs e)
        {
            DialogResult result = fdlgDatabase.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = fdlgDatabase.FileName;
                txtBoxDatabase.Text = file;
            }
        }

        private void CreateContainer()
        {
            //dummy username and password
            System.Security.SecureString password = new System.Security.SecureString();
            string dummypw = "password";
            Array.ForEach(dummypw.ToArray(), password.AppendChar);
            PSCredential credential = new PSCredential("admin",password);

            PowerShell ps = PowerShell.Create();
            ps.AddCommand("New-BCContainer");
            ps.AddParameter("-accept_eula");
            ps.AddParameter("-containerName",containerName());
            ps.AddParameter("-imageName", dockerImage());
            ps.AddParameter("-auth", "NavUserPassword");
            ps.AddParameter("-Credential", credential);
            ps.Invoke();

            string containerName()
            {
                //regex på containername
                //if regex check = valid then
                return txtBoxContainerName.Text;
            }

            string dockerImage()
            {
                string dockerImageString = "No image chosen";
                switch (cbImageSelector.Text)
                {
                    case "":
                        lblNotificationTxt.Text = "You must choose a base app.";
                        pnlNotification.Visible = true;
                        break;
                    case "Business Central On-premises":
                        dockerImageString = "\"mcr.microsoft.com/businesscentral/onprem\"";
                        break;
                    case "Business Central Cloud":
                        dockerImageString = "\"mcr.microsoft.com/businesscentral/sandbox\"";
                        break;
                    case "NAV":
                        dockerImageString = "\"microsoft/dynamics-nav\"";
                        break;
                    default:
                        dockerImageString = "\"mcr.microsoft.com/businesscentral/sandbox\"";
                        break;
                }
                //create version tag (combination of localization and version)
                pullImage(dockerImageString);
                return dockerImageString;

                void pullImage(string imageString)
                {
                    Process process = new Process();
                    ProcessStartInfo startinfo = new ProcessStartInfo
                    {
                        FileName = "CMD.exe",
                        Arguments = "/C docker pull " + imageString
                    };
                    process.StartInfo = startinfo;
                    process.Start();
                }
            }
        }
    }
}

//Functionality to build:
//Remove containers
//Advanced setup (container parameters)
//Import extensions to container
//Backup database from container
//Add test toolkit
//Clean up unused images