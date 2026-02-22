using TaskManager.Controls;
using TaskManager.Data;
using TaskManager.Models;

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

            ReloadProjects();
        }

        private void ReloadProjects()
        {
            lvProjectsList.Items.Clear();

            if (_AppData.Projects.Count < 1)
            {
                Label lbl = new Label();

                lbl.Text = "Brak projektów do wyświetlenia.";
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Font = new Font(lbl.Font.FontFamily, 12, FontStyle.Italic);

                panelProjectView.Controls.Clear();
                panelProjectView.Controls.Add(lbl);
            }       

            foreach (var project in _AppData.Projects)
            {
                ListViewItem item = new ListViewItem(project.Id.ToString());
                item.SubItems.Add(project.Name);

                if (project.Description.Length > 15)
                    item.ToolTipText = project.Description.Substring(0, 15) + "...";
                else
                    item.ToolTipText = project.Description;

                item.Tag = project;

                lvProjectsList.Items.Add(item);
            }
        }

        private void ProjectList_Click(object sender, EventArgs e)
        {

            if (lvProjectsList.SelectedItems.Count == 0)
                return;
            
            panelProjectView.Controls.Clear();
            
            var selectedProject = (Models.Project)lvProjectsList.SelectedItems[0].Tag;

            ProjectControl projectControl = new ProjectControl(selectedProject, _AppData);
            projectControl.Tag = selectedProject;
            projectControl.ProjectChanged += ProjectControl_Changed;

            panelProjectView.Controls.Add(projectControl);

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

        private void ProjectControl_Changed(object sender, EventArgs e)
        {
            ReloadProjects();
        }

    }
}
