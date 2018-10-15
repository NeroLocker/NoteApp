using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class AddEditNoteForm : Form
    {
        public AddEditNoteForm()
        {
            InitializeComponent();
        }

        public AddEditNoteForm(MainForm mainForm)
        {
            InitializeComponent();
            //mainForm.Enabled = false;
        }

        private void AddEditNoteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
