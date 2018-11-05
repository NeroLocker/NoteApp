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
    public partial class AddEditNoteForm : Form
    {
        /// <summary>
        /// Хранит текущую категорию
        /// </summary>
        private NoteCategory _currentCategory;

        /// <summary>
        /// Хранит флаг о необходимости редактировать заметку
        /// </summary>
        private bool _isEdit;

        /// <summary>
        /// Хранит объект текущей заметки
        /// </summary>
        private Note _currentNote;

        public bool IsEdit
        {
            get { return _isEdit; }
            set { _isEdit = value; }
        }

        public NoteCategory CurrentCategory
        {
            get { return _currentCategory; }
            set { _currentCategory = value; }
        }

        public Note CurrentNote
        {
            get { return _currentNote; }
            set { _currentNote = value; }
        }

        /// <summary>
        /// Конструктор, устанавливающий подсказки
        /// </summary>
        public AddEditNoteForm()
        {
            InitializeComponent();

            // Устанавливаем всплывающие подсказки
            OkButtonToolTip.SetToolTip(OkButton, "Save changes to current note");
            CancelButtonToolTip.SetToolTip(CancelButton, "Exit without saving");
        }

        /// <summary>
        /// Создаёт новую заметку
        /// </summary>
        public void AddNote()
        {
            // Флаг на редактирование
            IsEdit = false;

            // Имя заметки по умолчанию
            TitleTextBox.Text = "Note";
            FillCategoryItems();
            DateOfCreationTextBox.Text = DateTime.Now.ToString();
            DateOfLastEditTextBox.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// Редактирует текующую заметку
        /// </summary>
        /// <param name="currentNote"></param>
        public void EditNote(Note currentNote)
        {
            CurrentNote = currentNote;

            // Флаг на редактирование
            IsEdit = true;

            // Заполняем данные
            TitleTextBox.Text = CurrentNote.Name;
            FillCategoryItems();

            // Особый случай с категориями
            if (CurrentNote.Category == NoteCategory.HealthAndSport)
            {
                CategoryComboBox.Text = "Health and Sport";
            }
            else
            {
                CategoryComboBox.Text = CurrentNote.Category.ToString();
            }
            
            DateOfCreationTextBox.Text = CurrentNote.DateOfCreation.ToString();
            DateOfLastEditTextBox.Text = CurrentNote.DateOfLastEdit.ToString();
            ContentTextBox.Text = CurrentNote.Content;
        }      
        
        /// <summary>
        /// Заполняет категории заметки
        /// </summary>
        public void FillCategoryItems()
        {
            CategoryComboBox.Items.Add(NoteCategory.Work.ToString());
            CategoryComboBox.Items.Add(NoteCategory.Home.ToString());
            CategoryComboBox.Items.Add("Health and Sport");
            CategoryComboBox.Items.Add(NoteCategory.People.ToString());
            CategoryComboBox.Items.Add(NoteCategory.Documents.ToString());
            CategoryComboBox.Items.Add(NoteCategory.Finance.ToString());
            CategoryComboBox.Items.Add(NoteCategory.Other.ToString());
        }

        /// <summary>
        /// Событие нажатия кнопки Ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (TitleTextBox.Text == "")
            {
                TitleTextBox.BackColor = Color.MistyRose;
            }

            if (CategoryComboBox.Text == "")
            {
                CategoryComboBox.BackColor = Color.MistyRose;
            }

            if (ContentTextBox.Text == "")
            {
                ContentTextBox.BackColor = Color.MistyRose;
            }

            // Если редактируем
            if (IsEdit)
            {
                // Категория должна быть выбрана
                if (CategoryComboBox.SelectedIndex != -1)
                {
                    // Поля должны быть не пустыми
                    try
                    {
                        CurrentNote.Name = TitleTextBox.Text;
                    }
                    catch (ArgumentException exception)
                    {
                        if (exception.Message == "Name length is 0 symbols")
                        {
                            TitleTextBox.BackColor = Color.MistyRose;
                        }

                        if (exception.Message == "Name length is more than 70 symbols")
                        {
                            TitleTextBox.BackColor = Color.MistyRose;
                        }

                        if (exception.Message == "Name value starts with space symbol")
                        {
                            TitleTextBox.BackColor = Color.MistyRose;
                        }

                        if (exception.Message == "Name value contains special symbols")
                        {
                            TitleTextBox.BackColor = Color.MistyRose;
                        }

                        return;
                    }

                    try
                    {
                        CurrentNote.Content = ContentTextBox.Text;
                    }
                    catch (ArgumentException exception)
                    {
                        if (exception.Message == "Content length is 0 symbols")
                        {
                            ContentTextBox.BackColor = Color.MistyRose;
                        }

                        if (exception.Message == "Content length is more than 4096 symbols")
                        {
                            ContentTextBox.BackColor = Color.MistyRose;
                        }

                        if (exception.Message == "Content value starts with space symbol")
                        {
                            ContentTextBox.BackColor = Color.MistyRose;
                        }

                        return;
                    }

                    CurrentNote.Category = CurrentCategory;
                    CurrentNote.DateOfLastEdit = DateTime.Now;

                    this.DialogResult = DialogResult.OK;
                }
            }
            // Если создаём новую заметку
            else
            {
                // Категория должна быть выбрана
                if (CategoryComboBox.SelectedIndex != -1)
                {                   
                    // Поля должны быть не пустыми
                    try
                    {
                        CurrentNote = new Note(TitleTextBox.Text, ContentTextBox.Text, CurrentCategory);
                    }
                    catch (ArgumentException exception)
                    {
                        // Name
                        if (exception.Message == "Name length is 0 symbols")
                        {
                            TitleTextBox.BackColor = Color.MistyRose;
                        }

                        if (exception.Message == "Name length is more than 70 symbols")
                        {
                            TitleTextBox.BackColor = Color.MistyRose;
                        }

                        if (exception.Message == "Name value starts with space symbol")
                        {
                            TitleTextBox.BackColor = Color.MistyRose;
                        }

                        if (exception.Message == "Name value contains special symbols")
                        {
                            TitleTextBox.BackColor = Color.MistyRose;
                        }

                        // Content
                        if (exception.Message == "Content length is 0 symbols")
                        {
                            ContentTextBox.BackColor = Color.MistyRose;
                        }

                        if (exception.Message == "Content length is more than 4096 symbols")
                        {
                            ContentTextBox.BackColor = Color.MistyRose;
                        }

                        if (exception.Message == "Content value starts with space symbol")
                        {
                            ContentTextBox.BackColor = Color.MistyRose;
                        }

                        return;
                    }

                    this.DialogResult = DialogResult.OK;
                }
            }
        }


        /// <summary>
        /// Событие при смене категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = CategoryComboBox.SelectedIndex;
            
            CategoryComboBox.BackColor = Color.White;            

            // Если категория выбрана
            if (categoryId != -1)
            {
                if (CategoryComboBox.SelectedIndex == 0)
                {
                    CurrentCategory = NoteCategory.Work;
                }

                if (CategoryComboBox.SelectedIndex == 1)
                {
                    CurrentCategory = NoteCategory.Home;
                }

                if (CategoryComboBox.SelectedIndex == 2)
                {
                    CurrentCategory = NoteCategory.HealthAndSport;
                }

                if (CategoryComboBox.SelectedIndex == 3)
                {
                    CurrentCategory = NoteCategory.People;
                }

                if (CategoryComboBox.SelectedIndex == 4)
                {
                    CurrentCategory = NoteCategory.Documents;
                }

                if (CategoryComboBox.SelectedIndex == 5)
                {
                    CurrentCategory = NoteCategory.Finance;
                }

                if (CategoryComboBox.SelectedIndex == 6)
                {
                    CurrentCategory = NoteCategory.Other;
                }
            }
        }

        /// <summary>
        /// Событие при нажатии кнопки Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to exit without saving?", "NoteApp",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }


        # region Focus

        /// <summary>
        /// Событие фокусировки на TitleBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleTextBox_Enter(object sender, EventArgs e)
        {
            TitleTextBox.BackColor = Color.White;            
        }

        /// <summary>
        /// Событие фокусировки на CategoryComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_Enter(object sender, EventArgs e)
        {
            CategoryComboBox.BackColor = Color.White;
        }

        /// <summary>
        /// Событие фокусировки на ContentTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContentTextBox_Enter(object sender, EventArgs e)
        {
            ContentTextBox.BackColor = Color.White;
        }

        #endregion
    }
}