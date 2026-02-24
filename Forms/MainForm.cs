using TaskManager.Controls;
using TaskManager.Data;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager
{
    public partial class MainForm : Form
    {
        private readonly ProjectService _projectService;
        private int? _currentProjectId;
        public MainForm(ProjectService projectService)
        {
            InitializeComponent();
            _projectService = projectService;
            _projectService.ProjectChanged += ProjectService_ProjectsChanged;

            // Ustawienie szerokości kolumn i opcji wyświetlania
            lvProjectsList.Columns[1].Width = lvProjectsList.Width - lvProjectsList.Columns[0].Width;
            lvProjectsList.FullRowSelect = true;
            lvProjectsList.GridLines = true;
            lvProjectsList.HideSelection = false;
            lvProjectsList.ShowItemToolTips = true;
        }

        // Metoda do przeładowania listy projektów
        private void ReloadProjects()
        {
            lvProjectsList.Items.Clear();
            var projects = _projectService.GetAll();

            if (projects.Count < 1)
            {
                Label lbl = new Label();

                lbl.Text = "Brak projektów do wyświetlenia.";
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Font = new Font(lbl.Font.FontFamily, 12, FontStyle.Italic);

                panelProjectView.Controls.Clear();
                panelProjectView.Controls.Add(lbl);
            }       

            foreach (var project in projects)
            {
                ListViewItem item = new ListViewItem(project.Id.ToString());
                item.SubItems.Add(project.Name);

                if (project.Description.Length > 15)
                    item.ToolTipText = project.Description.Substring(0, 15) + "...";
                else
                    item.ToolTipText = project.Description;

                item.Tag = project.Id;

                lvProjectsList.Items.Add(item);
            }
        }

        // Obsługa zdarzenia kliknięcia na projekt w liście
        private void ProjectList_Click(object sender, EventArgs e)
        {

            if (lvProjectsList.SelectedItems.Count == 0)
                return;
            
            _currentProjectId = (int?)lvProjectsList.SelectedItems[0].Tag;

            ShowProjectInPanel(_currentProjectId);

        }

        // Obsługa zdarzenia dodawania projektu
        private void btnAddProject_Click(object sender, EventArgs e)
        {
            Forms.ProjectForm addProjectForm = new Forms.ProjectForm(_projectService, null, false);
            addProjectForm.ShowDialog();

            if (addProjectForm.DialogResult == DialogResult.OK)
            {
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

            int selectedProjectId = (int)lvProjectsList.SelectedItems[0].Tag;

            var selectedProject = _projectService.GetById(selectedProjectId);
            _currentProjectId = selectedProjectId;


            Forms.ProjectForm editProjectForm = new Forms.ProjectForm(_projectService, selectedProject, true);


            editProjectForm.ShowDialog();

            if (editProjectForm.DialogResult == DialogResult.OK)
            {
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
            var selectedProjectId = (int)lvProjectsList.SelectedItems[0].Tag;

            var selectedProject = _projectService.GetById(selectedProjectId);
            _currentProjectId = selectedProjectId;


            var confirmResult = MessageBox.Show($"Czy na pewno chcesz usunąć projekt '{selectedProject.Name}'?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                _projectService.Delete(selectedProjectId);
                MessageBox.Show("Pomyślnie usunięto projekt!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Nie usunięto projektu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Metoda do wyświetlania szczegółów projektu w panelu
        private void ShowProjectInPanel(int? projectId)
        {
            panelProjectView.Controls.Clear();

            if (_projectService.GetAll().Count < 1)
                return;

            var project = _projectService.GetById((int)projectId);
            if (project == null)
                return;
            
            var pc = new ProjectControl(project.Id, _projectService);

            panelProjectView.Controls.Add(pc);
        }

        private void ProjectService_ProjectsChanged(object? sender, EventArgs e)
        {
            ReloadProjects();
            
            if(_currentProjectId.HasValue)
                ShowProjectInPanel(_currentProjectId);
        }
    }
}
