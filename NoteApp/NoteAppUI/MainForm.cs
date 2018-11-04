using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранит экземпляр текущего проекта
        /// </summary>
        private Project _currentProject;

        /// <summary>
        /// Хранит номер текущей заметки
        /// </summary>
        private int _noteId;

        public int NoteId
        {
            get { return _noteId; }
            set { _noteId = value; }
        }

        public Project CurrentProject
        {
            get { return _currentProject; }
            set { _currentProject = value; }
        }

        public MainForm()
        {
            InitializeComponent();

            // Попытка загрузить существующий проект, если его нет - создаём новый
            try
            {
                CurrentProject = ProjectManager.LoadFromFile("Project");

            }
            // Создаём директорию хранения файла проекта, если её нет
            catch (DirectoryNotFoundException)
            {
                if (Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp") == false)
                {
                    Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp");
                    File.Create(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes");

                    CurrentProject = new Project("Project");
                }                
            }
            // Создаём пустой файл хранения проекта
            catch (FileNotFoundException)
            {
                if (Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes") == false)
                {
                    File.Create(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NoteApp\\NoteApp.notes");
                }

                CurrentProject = new Project("Project");
            }

            // Подгружаем данные в ListBox
            NotesListBox.DataSource = CurrentProject.NotesCollection;
            NotesListBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Обновляет данные ListBox заметок
        /// </summary>
        private void UpdateNotesList()
        {
            // Перезагружаем проект
            CurrentProject = ProjectManager.LoadFromFile("Project");

            // Обновляем данные коллекции
            NotesListBox.DataSource = null;
            NotesListBox.DataSource = CurrentProject.NotesCollection;
            NotesListBox.DisplayMember = "Name";
        }

        // Всё что относится к меню
        # region Menu

        /// <summary>
        /// Событие при нажатии пункта меню AddNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyAddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Можно добавить только до 200 заметок
            if (CurrentProject.NotesCollection.Count < 200)
            {
                AddEditNoteForm addEditNoteForm = new AddEditNoteForm();
                addEditNoteForm.AddNote();

                if (addEditNoteForm.ShowDialog() == DialogResult.OK)
                {                    
                    CurrentProject.NotesCollection.Add(addEditNoteForm.CurrentNote);
                    ProjectManager.SaveToFile(CurrentProject, "Project");
                    UpdateNotesList();
                }
            }
            else
            {
                // Подсвечиваем ListBox заметок
                NotesListBox.BackColor = Color.MistyRose;
            }            
        }

        /// <summary>
        /// Событие при нажатии пункта меню EditNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyEditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Должна быть выбрана заметка
            if (NotesListBox.SelectedIndex != -1)
            {
                AddEditNoteForm addEditNoteForm = new AddEditNoteForm();
                addEditNoteForm.EditNote(CurrentProject.NotesCollection[NoteId]);

                //AddEditNoteForm addEditNoteForm = new AddEditNoteForm(CurrentProject.NotesCollection[NoteId]);
                if (addEditNoteForm.ShowDialog() == DialogResult.OK)
                {
                    CurrentProject.NotesCollection[NoteId] = addEditNoteForm.CurrentNote;
                    ProjectManager.SaveToFile(CurrentProject, "Project");
                    UpdateNotesList();
                }
            }
            else
            {
                NotesListBox.BackColor = Color.MistyRose;                
            }
        }

        /// <summary>
        /// Собите при нажатии пункта меню About
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();

            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Событие при нажатии пункта меню Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Для сохранения список заметок должен быть не пустым
            if (CurrentProject.NotesCollection.Count != 0)
            {
                ProjectManager.SaveToFile(CurrentProject, "Project");
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Событие при нажатии пункта меню RemoveNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyRemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Должна быть выбрана заметка
            if (NotesListBox.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Do you want to remove note?", "NoteApp", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CurrentProject.NotesCollection.RemoveAt(NoteId);
                    ProjectManager.SaveToFile(CurrentProject, "Project");
                    UpdateNotesList();

                    this.DialogResult = DialogResult.Cancel;
                }

                if (result == DialogResult.No)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                NotesListBox.BackColor = Color.MistyRose;
            }
        }

        #endregion

        // Всё что относится к кнопкам
        # region Buttons

        /// <summary>
        /// Событие при нажатии кнопки NewNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            AddEditNoteForm addEditNoteForm = new AddEditNoteForm();
            addEditNoteForm.AddNote();

            // Можно добавить только до 200 заметок
            if (CurrentProject.NotesCollection.Count < 200)
            {
                if (addEditNoteForm.ShowDialog() == DialogResult.OK)
                {
                    CurrentProject.NotesCollection.Add(addEditNoteForm.CurrentNote);
                    ProjectManager.SaveToFile(CurrentProject, "Project");
                    UpdateNotesList();
                }
            }
            else
            {
                // Подсвечиваем ListBox заметок
                NotesListBox.BackColor = Color.MistyRose;                
            }
        }

        /// <summary>
        /// Событие при нажатии кнопки EditNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            // Должна быть выбрана заметка
            if (NotesListBox.SelectedIndex != -1)
            {
                //AddEditNoteForm addEditNoteForm = new AddEditNoteForm(CurrentProject.NotesCollection[NoteId]);
                AddEditNoteForm addEditNoteForm = new AddEditNoteForm();
                addEditNoteForm.EditNote(CurrentProject.NotesCollection[NoteId]);

                if (addEditNoteForm.ShowDialog() == DialogResult.OK)
                {
                    CurrentProject.NotesCollection[NoteId] = addEditNoteForm.CurrentNote;
                    ProjectManager.SaveToFile(CurrentProject, "Project");
                    UpdateNotesList();
                }
            }
            else
            {
                NotesListBox.BackColor = Color.MistyRose;
            }
        }

        /// <summary>
        /// Событие при нажатии кнопки RemoveNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            // Должна быть выбрана заметка
            if (NotesListBox.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Do you want to remove note?", "NoteApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Удаляем заметку по id
                    CurrentProject.NotesCollection.RemoveAt(NoteId);
                    ProjectManager.SaveToFile(CurrentProject, "Project");
                    UpdateNotesList();

                    this.DialogResult = DialogResult.Cancel;
                }

                if (result == DialogResult.No)
                {
                    // Просто закрываем диалог
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                NotesListBox.BackColor = Color.MistyRose;
            }            
        }

        #endregion

        /// <summary>
        /// Событие изменения индекса выбранной заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NoteId = NotesListBox.SelectedIndex;

            // Возвращаем стандартный цвет
            NotesListBox.BackColor = Color.White;

            if (NoteId != -1)
            {
                NoteNameLabel.Text = CurrentProject.NotesCollection[NoteId].Name;

                // Особый случай с категориями
                if (CurrentProject.NotesCollection[NoteId].Category == NoteCategory.HealthAndSport)
                {
                    CategoryLabel.Text = "Health and Sport";
                }
                else
                {
                    CategoryLabel.Text = CurrentProject.NotesCollection[NoteId].Category.ToString();
                }
                
                DateOfCreationTextBox.Text = CurrentProject.NotesCollection[NoteId].DateOfCreation.ToString();
                DateOfLastEditTextBox.Text = CurrentProject.NotesCollection[NoteId].DateOfLastEdit.ToString();
                ContentTextBox.Text = CurrentProject.NotesCollection[NoteId].Content;
            }
        }

        /// <summary>
        /// Событие перед закрытием окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "NoteApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Для сохранения список заметок должен быть не пустым
                if (CurrentProject.NotesCollection.Count != 0)
                {
                    ProjectManager.SaveToFile(CurrentProject, "Project");
                }                      
            }

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Событие фокусировки на ListBox заметок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotesListBox_Enter(object sender, EventArgs e)
        {
            NotesListBox.BackColor = Color.White;
        }
    }
}