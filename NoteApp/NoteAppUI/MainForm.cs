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
        
        public Project CurrentProject
        {
            get { return _currentProject; }
            set { _currentProject = value; }
        }

        /// <summary>
        /// Хранит список отфильтрованный по категории
        /// </summary>
        public List<Note> FilteredList { get; set; }

        /// <summary>
        /// Хранит index текущей заметки
        /// </summary>
        public int NoteIndex { get; set; }

        /// <summary>
        /// Флаг первого изменения индекса списка заметок
        /// </summary>
        private bool _flag = false;

        public MainForm()
        {
            InitializeComponent();

            // Задаем клавишу быстрого доступа для удаления заметки
            MyRemoveNoteToolStripMenuItem.ShortcutKeys = Keys.Delete;

            // Загружаем сохранённый проект
            CurrentProject = ProjectManager.LoadFromFile();

            // Если нет заметок - ничего не делаем
            try
            {
                CurrentProject.SortNotesCollection();
            }
            catch (InvalidOperationException)
            {                
            }

            this.NotesListBox.DataSource = CurrentProject.NotesCollection;
            this.NotesListBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Обновляет данные списка заметок
        /// </summary>
        private void UpdateNotesList()
        {
            // Стираем отфильтрованный список
            FilteredList = null;

            // Сохраняемся всякий раз, когда обновляем данные
            ProjectManager.SaveToFile(CurrentProject);

            // Перезагружаем проект
            CurrentProject = ProjectManager.LoadFromFile();

            // Если нет заметок - ничего не делаем
            try
            {
                CurrentProject.SortNotesCollection();
            }
            catch (InvalidOperationException)
            {
            }
            
            // Обновляем данные коллекции
            NotesListBox.DataSource = null;
            NotesListBox.DataSource = CurrentProject.NotesCollection;
            NotesListBox.DisplayMember = "Name";

            CategoryComboBox.SelectedIndex = 7;
        }

        /// <summary>
        /// Обновляет данные списка заметок по конкретной конкретной категории
        /// </summary>
        private void UpdateNotesList(NoteCategory category)
        {
            // Сохраняемся всякий раз, когда обновляем данные
            ProjectManager.SaveToFile(CurrentProject);

            // Перезагружаем проект
            CurrentProject = ProjectManager.LoadFromFile();

            // Если нет заметок - ничего не делаем
            try
            {
                CurrentProject.SortNotesCollection();
            }
            catch (InvalidOperationException)
            {

            }

            // Обновляем данные коллекции
            NotesListBox.DataSource = null;

            // Если пришёл пустой список - ничего не делаем
            try
            {
                FilteredList = CurrentProject.SortNotesCollection(category);
                NotesListBox.DataSource = FilteredList;
            }
            catch (InvalidOperationException)
            {
            }
            
            NotesListBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Чистит все информационные поля заметки
        /// </summary>
        private void ClearFields()
        {
            NoteNameLabel.Text = "";
            CategoryLabel.Text = "";
            DateOfCreationTextBox.Text = "";
            DateOfLastEditTextBox.Text = "";
            ContentTextBox.Text = "";
        }

        public void SetAllFieldsOfCurrentNote()
        {
            if (FilteredList == null)
            {
                // Меняем название заметки
                NoteNameLabel.Text = CurrentProject.NotesCollection[NoteIndex].Name;

                // Особый случай с категориями
                if (CurrentProject.NotesCollection[NoteIndex].Category == NoteCategory.HealthAndSport)
                {
                    CategoryLabel.Text = "Health and Sport";
                }
                else
                {
                    CategoryLabel.Text = CurrentProject.NotesCollection[NoteIndex].Category.ToString();
                }

                // Меняем все остальные поля
                DateOfCreationTextBox.Text = CurrentProject.NotesCollection[NoteIndex].DateOfCreation.ToString();
                DateOfLastEditTextBox.Text = CurrentProject.NotesCollection[NoteIndex].DateOfLastEdit.ToString();
                ContentTextBox.Text = CurrentProject.NotesCollection[NoteIndex].Content;
            }
            else
            {
                // Меняем название заметки
                NoteNameLabel.Text = FilteredList[NoteIndex].Name;

                // Особый случай с категориями
                if (FilteredList[NoteIndex].Category == NoteCategory.HealthAndSport)
                {
                    CategoryLabel.Text = "Health and Sport";
                }
                else
                {
                    CategoryLabel.Text = FilteredList[NoteIndex].Category.ToString();
                }

                // Меняем все остальные поля
                DateOfCreationTextBox.Text = FilteredList[NoteIndex].DateOfCreation.ToString();
                DateOfLastEditTextBox.Text = FilteredList[NoteIndex].DateOfLastEdit.ToString();
                ContentTextBox.Text = FilteredList[NoteIndex].Content;
            }           
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
                addEditNoteForm.EditNote(CurrentProject.NotesCollection[NoteIndex]);

                if (addEditNoteForm.ShowDialog() == DialogResult.OK)
                {
                    CurrentProject.NotesCollection[NoteIndex] = addEditNoteForm.CurrentNote;                    
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
                ProjectManager.SaveToFile(CurrentProject);
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
                    CurrentProject.NotesCollection.Remove(CurrentProject.NotesCollection[NoteIndex]);                    
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
                // Подсвечиваем ListBox заметок
                NotesListBox.BackColor = Color.MistyRose;
            }
        }

        #endregion

        // Всё что относится к кнопкам
        # region Buttons

        /// <summary>
        /// Событие при нажатии кнопки AddNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            MyAddNoteToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Событие при нажатии кнопки EditNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            MyEditNoteToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Событие при нажатии кнопки RemoveNote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {            
            MyRemoveNoteToolStripMenuItem_Click(sender, e);
        }

        #endregion

        /// <summary>
        /// Событие изменения индекса выбранной заметки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {           
            // Проверка что программа открыта в первый раз
            if (_flag == false)
            {
                int indexOfLastNote = 0;

                // Проверка что записка есть
                if (CurrentProject.CurrentNote != null)
                {
                    // Поиск индекса последней открытой заметки
                    foreach (Note element in CurrentProject.NotesCollection)
                    {
                        if (element.DateOfLastEdit == CurrentProject.CurrentNote.DateOfLastEdit)
                        {
                            indexOfLastNote = CurrentProject.NotesCollection.IndexOf(element);
                        }
                    }
                }

                // Выделяем последнюю открытую заметку
                NotesListBox.SelectedIndex = indexOfLastNote;
                _flag = true;
            }

            // Храним индекс текущей выбранной заметки
            NoteIndex = NotesListBox.SelectedIndex;

            // Возвращаем стандартный цвет
            NotesListBox.BackColor = Color.White;

            // Должна быть выбрана заметка
            if (NotesListBox.SelectedIndex != -1)
            {
                SetAllFieldsOfCurrentNote();                
            }
            else
            {
                // Если заметка не выделена
                ClearFields();
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
                    if (NotesListBox.SelectedIndex != -1)
                    {
                        CurrentProject.CurrentNote = CurrentProject.NotesCollection[NoteIndex];
                    }

                    if (NotesListBox.SelectedIndex == -1)
                    {
                        CurrentProject.CurrentNote = null;
                    }
                    
                    ProjectManager.SaveToFile(CurrentProject);
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

        /// <summary>
        /// Событие при изменении индекса категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Сортируем список в зависимости от категории
            switch (CategoryComboBox.SelectedIndex)
            {
                case 0:
                    UpdateNotesList(NoteCategory.Work);
                    break;
                case 1:
                    UpdateNotesList(NoteCategory.Home);
                    break;
                case 2:
                    UpdateNotesList(NoteCategory.HealthAndSport);
                    break;
                case 3:
                    UpdateNotesList(NoteCategory.People);
                    break;
                case 4:
                    UpdateNotesList(NoteCategory.Documents);
                    break;
                case 5:
                    UpdateNotesList(NoteCategory.Finance);
                    break;
                case 6:
                    UpdateNotesList(NoteCategory.Other);
                    break;
                case 7:
                    UpdateNotesList();
                    break;
            }
        }
    }
}