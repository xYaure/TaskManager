using TaskManager.Data;

namespace TaskManager
{
    public partial class MainForm : Form
    {
        private readonly AppData _AppData;
        public MainForm(AppData appData)
        {
            InitializeComponent();
            _AppData = appData;

            // Ustawienie szerokości kolumn i opcji wyświetlania
            lvProjectsList.Columns[1].Width = lvProjectsList.Width - lvProjectsList.Columns[0].Width;
            lvProjectsList.FullRowSelect = true;
            lvProjectsList.GridLines = true;
            lvProjectsList.HideSelection = false;
            lvProjectsList.ShowItemToolTips = true;


        }

        private void ReloadProjects()
        {
            lvProjectsList.Items.Clear();
            foreach (var project in _AppData.Projects)
            {
                ListViewItem item = new ListViewItem(project.Id.ToString());
                item.SubItems.Add(project.Name);

                if (project.Description.Length > 15)
                    item.ToolTipText = project.Description.Substring(0, 15) + "...";

                item.Tag = project;

                lvProjectsList.Items.Add(item);
            }

            label1.Text = $"Nazwa: {_AppData.Projects[0].Name}";
            label2.Text = $"Opis: {_AppData.Projects[0].Description}";
            label3.Text = $"Data utworzenia: {_AppData.Projects[0].CreatedAt}";
            label4.Text = $"Data modyfikowania: {_AppData.Projects[0].UpdatedAt}";

        }


        // Obsługa zdarzenia dodawania projektu
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            Forms.ProjectForm addProjectForm = new Forms.ProjectForm(_AppData, null, false);
            addProjectForm.ShowDialog();

            if (addProjectForm.DialogResult == DialogResult.OK)
            {
                ReloadProjects();
                MessageBox.Show("Pomyślnie dodano projekt!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Nie dodano projektu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Obsługa zdarzenia edytowania projektu
        private void emiEditProject_Click(object sender, EventArgs e)
        {
            if (lvProjectsList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano projektu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedProject = (Models.Project)lvProjectsList.SelectedItems[0].Tag;
            Forms.ProjectForm editProjectForm = new Forms.ProjectForm(_AppData, selectedProject, true);
            editProjectForm.ShowDialog();

            if (editProjectForm.DialogResult == DialogResult.OK)
            {
                ReloadProjects();
                MessageBox.Show("Pomyślnie edytowano projekt!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Nie edytowano projektu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Obsługa zdarzenia usuwania projektu
        private void emiDeleteProject_Click(object sender, EventArgs e)
        {
            if (lvProjectsList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nie wybrano projektu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedProject = (Models.Project)lvProjectsList.SelectedItems[0].Tag;
            var confirmResult = MessageBox.Show($"Czy na pewno chcesz usunąć projekt '{selectedProject.Name}'?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                _AppData.DeleteProject(selectedProject);
                ReloadProjects();
                MessageBox.Show("Pomyślnie usunięto projekt!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Nie usunięto projektu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
