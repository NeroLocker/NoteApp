using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        Project myProject = new Project("myfile");
        NoteCategory category = NoteCategory.Other;
        int noteNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MyAddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditNoteForm addEditNoteForm = new AddEditNoteForm(this);
            addEditNoteForm.ShowDialog();
        }

        private void MyAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }


        //private void saveButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        myProject.NotesCollection.Add(new Note(nameOfNoteTextBox.Text, noteContentTextBox.Text, category));
        //    }
        //    catch (ArgumentException ex)
        //    {
        //        greetingsLabel.Text = "Argument Exception";
        //        return;
        //    }
        //    catch (Exception ex)
        //    {
        //        greetingsLabel.Text = "Some Exception";
        //        return;                                
        //    }                      

        //    nameTextLabel.Text = myProject.NotesCollection[noteNumber].Name;
        //    contentTextBox.Text = myProject.NotesCollection[noteNumber].Content;
        //    dateOfCreationTextBox.Text = myProject.NotesCollection[noteNumber].DateOfCreation.ToString();
        //    dateOfLastEditTextBox.Text = myProject.NotesCollection[noteNumber].DateOfLastEdit.ToString();
        //    categoryLabel.Text = myProject.NotesCollection[noteNumber].Category.ToString();

        //    listOfNotesTextBox.Text += myProject.NotesCollection[noteNumber].Name + "\r\n";
        //    listOfNotesComboBox.Items.Add(myProject.NotesCollection[noteNumber].Name);

        //    nameOfNoteTextBox.Text = "";
        //    noteContentTextBox.Text = "";
        //    listOfNotesComboBox.Text = "";
        //    noteCategoryListBox.SelectedIndex = -1;

        //    ProjectManager.SaveToFile(myProject, "myfile");

        //    noteNumber += 1;

        //}

        //private void listOfNotesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //        int index = (int)listOfNotesComboBox.SelectedIndex;
        //        contentTextBox.Text = myProject.NotesCollection[index].Content;
        //        nameTextLabel.Text = myProject.NotesCollection[index].Name;
        //        dateOfCreationTextBox.Text = myProject.NotesCollection[index].DateOfCreation.ToString();
        //        dateOfLastEditTextBox.Text = myProject.NotesCollection[index].DateOfLastEdit.ToString();
        //        categoryLabel.Text = myProject.NotesCollection[index].Category.ToString();

        //}

        //private void deleteButton_Click(object sender, EventArgs e)
        //{
        //    if (listOfNotesComboBox.SelectedIndex != -1)
        //    {
        //        int index = listOfNotesComboBox.SelectedIndex;

        //        myProject.NotesCollection.Remove(myProject.NotesCollection[index]);

        //        listOfNotesComboBox.Items.RemoveAt(index);
        //        listOfNotesComboBox.Text = "";
        //        noteCategoryListBox.SelectedIndex = -1;
        //        listOfNotesComboBox.SelectedIndex = -1;

        //        noteNumber -= 1;
        //    }            
        //}

        //private void listBoxOfNoteCategory_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (noteCategoryListBox.SelectedIndex != -1)
        //    {
        //        if (noteCategoryListBox.SelectedIndex == 0)
        //        {
        //            category = NoteCategory.Work;
        //        }

        //        if (noteCategoryListBox.SelectedIndex == 1)
        //        {
        //            category = NoteCategory.Home;
        //        }

        //        if (noteCategoryListBox.SelectedIndex == 2)
        //        {
        //            category = NoteCategory.HealthAndSport;
        //        }

        //        if (noteCategoryListBox.SelectedIndex == 3)
        //        {
        //            category = NoteCategory.People;
        //        }

        //        if (noteCategoryListBox.SelectedIndex == 4)
        //        {
        //            category = NoteCategory.Documents;
        //        }

        //        if (noteCategoryListBox.SelectedIndex == 5)
        //        {
        //            category = NoteCategory.Finance;
        //        }

        //        if (noteCategoryListBox.SelectedIndex == 6)
        //        {
        //            category = NoteCategory.Other;
        //        }
        //    }
        //}

        //private void saveToFileButton_Click(object sender, EventArgs e)
        //{
        //    ProjectManager.SaveToFile(myProject, "myfile");

        //    ProjectManager.LoadFromFile("myfile");

        //}

        //private void editButton_Click(object sender, EventArgs e)
        //{
        //    int index = listOfNotesComboBox.SelectedIndex;

        //}

        //private void MainForm_Load(object sender, EventArgs e)
        //{

        //}
    }
}
