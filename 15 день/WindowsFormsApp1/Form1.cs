using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Note> notes = new List<Note>(); // List of notes
        private string notesFilePath = "notes.json"; // Path to the notes JSON file

        public Form1()
        {
            InitializeComponent();
            LoadNotesFromFile(); // Load notes from file on application startup
        }

        private void AddNoteToCalendar(DateTime date, string text)
        {
            Note note = new Note { Date = date, Text = text };
            notes.Add(note);
            SaveNotesToFile(); // Save notes to file after adding a new note
        }

        private void LoadNotesFromFile()
        {
            if (File.Exists(notesFilePath))
            {
                string json = File.ReadAllText(notesFilePath);
                notes = JsonSerializer.Deserialize<List<Note>>(json);
            }
        }

        private void SaveNotesToFile()
        {
            string json = JsonSerializer.Serialize(notes);
            File.WriteAllText(notesFilePath, json);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;

            // Check if there is already a note for the selected date
            Note existingNote = notes.FirstOrDefault(n => n.Date.Date == selectedDate.Date);
            if (existingNote != null)
            {
                // If a note already exists, offer to edit it
                Form2 dialog = new Form2("Редактировать заметку", "Введите текст заметки:");
                dialog.textBoxInput.Text = existingNote.Text;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    existingNote.Text = dialog.EnteredText;
                    MessageBox.Show("Заметка успешно отредактирована.");
                    SaveNotesToFile(); // Save notes to file after editing a note
                }
                else
                {
                    MessageBox.Show("Редактирование заметки отменено.");
                }
            }
            else
            {
                // If there is no note, prompt to enter a new note
                Form2 dialog = new Form2("Добавить заметку", "Введите текст заметки:");
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    AddNoteToCalendar(selectedDate, dialog.EnteredText);
                    MessageBox.Show("Заметка успешно добавлена.");
                }
                else
                {
                    MessageBox.Show("Добавление заметки отменено.");
                }
            }
        }
    }
}