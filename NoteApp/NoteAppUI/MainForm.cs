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
        int counter = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            try
            {
                myProject.AddNote(new Note(nameOfNoteTextBox.Text, noteContentTextBox.Text, category));
            }
            catch (ArgumentException ex)
            {
                greetingsLabel.Text = "Argument Exception";
                return;
            }
            catch (Exception ex)
            {
                greetingsLabel.Text = "Some Exception";
                return;                                
            }                      

            nameTextLabel.Text = myProject.ListOfNotes[counter].Name;
            contentTextBox.Text = myProject.ListOfNotes[counter].Content;
            dateOfCreationTextBox.Text = myProject.ListOfNotes[counter].DateOfCreation.ToString();
            dateOfLastEditTextBox.Text = myProject.ListOfNotes[counter].DateOfLastEdit.ToString();

            categoryLabel.Text = myProject.ListOfNotes[counter].Category.ToString();

            listOfNotesTextBox.Text += myProject.ListOfNotes[counter].Name + "\r\n";
            listOfNotesComboBox.Items.Add(myProject.ListOfNotes[counter].Name);

            nameOfNoteTextBox.Text = "";
            noteContentTextBox.Text = "";
            listOfNotesComboBox.Text = "";
            listBoxOfNoteCategory.SelectedIndex = -1;

            ProjectManager.SaveToFile(myProject, "myfile");

            counter += 1;

        }

        private void listOfNotesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfNotesComboBox.SelectedIndex != 1)
            {
                int index = (int)listOfNotesComboBox.SelectedIndex;
                contentTextBox.Text = myProject.ListOfNotes[index].Content;
                nameTextLabel.Text = myProject.ListOfNotes[index].Name;
                dateOfCreationTextBox.Text = myProject.ListOfNotes[index].DateOfCreation.ToString();
                dateOfLastEditTextBox.Text = myProject.ListOfNotes[index].DateOfLastEdit.ToString();
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listOfNotesComboBox.SelectedIndex != -1)
            {
                int index = (int)listOfNotesComboBox.SelectedIndex;

                myProject.DeleteNote(myProject.ListOfNotes[index].DateOfCreation);
                listOfNotesComboBox.Items.RemoveAt(index);

                listOfNotesComboBox.Text = "";
                listBoxOfNoteCategory.SelectedIndex = -1;
                listOfNotesComboBox.SelectedIndex = -1;

                counter -= 1;
            }            
        }

        private void listBoxOfNoteCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOfNoteCategory.SelectedIndex != -1)
            {
                if (listBoxOfNoteCategory.SelectedIndex == 0)
                {
                    category = NoteCategory.Work;
                }

                if (listBoxOfNoteCategory.SelectedIndex == 1)
                {
                    category = NoteCategory.Home;
                }

                if (listBoxOfNoteCategory.SelectedIndex == 2)
                {
                    category = NoteCategory.HealthAndSport;
                }

                if (listBoxOfNoteCategory.SelectedIndex == 3)
                {
                    category = NoteCategory.People;
                }

                if (listBoxOfNoteCategory.SelectedIndex == 4)
                {
                    category = NoteCategory.Documents;
                }

                if (listBoxOfNoteCategory.SelectedIndex == 5)
                {
                    category = NoteCategory.Finance;
                }

                if (listBoxOfNoteCategory.SelectedIndex == 6)
                {
                    category = NoteCategory.Other;
                }
            }
        }

        private void saveToFileButton_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveToFile(myProject, "myfile");

            ProjectManager.LoadFromFile("myfile");

        }
    }
}
