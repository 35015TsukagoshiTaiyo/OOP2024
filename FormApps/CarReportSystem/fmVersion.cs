using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmVersion : Form {
        public fmVersion() {
            InitializeComponent();
        }

        private void btVersionOK_Click(object sender, EventArgs e) {
            Close();
        }

        private void fmVersion_Load(object sender, EventArgs e) {
            var asm = Assembly.GetExecutingAssembly();
            var asmTitleAttr = asm.GetCustomAttribute<AssemblyTitleAttribute>();
            var asmCopyRightAttr = asm.GetCustomAttribute<AssemblyCopyrightAttribute>();
            var asmVersion = asm.GetName().Version;

            lbTitle.Text = asmTitleAttr?.Title ?? "";

            lbVersion.Text = $"Version {asmVersion}";

            lbCompany.Text = "copyright(c) "+
                          asmCopyRightAttr.Copyright +" "+ 
                          Application.CompanyName;
            //lbCompany.Text = $"Copyright (c) {asmCopyRightAttr?.Copyright}";
        }


    }
}
