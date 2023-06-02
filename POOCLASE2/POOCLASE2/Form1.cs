using System.Windows.Forms;

namespace POOCLASE2
{
    public partial class Form1 : Form
    {
        PersonarController controller = new PersonarController();
        public Form1()
        {

            InitializeComponent();


        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            String Nombre = TbNombre.Text;
            String Apellido = TbApellido.Text;
            String DNI = TbDNI.Text;
            int Edad = int.Parse(TbEdad.Text);

            Boolean resp = controller.add_persona(DNI, Nombre, Apellido, Edad);
            if (resp)
            {
                mostrar_datos();
                DgvPersonas.DataSource = controller.get_personas();
                MessageBox.Show("Insertado exitosamente ");
            }
            else
            {
                MessageBox.Show("Algo Salio mal, intente de nuevo");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrar_datos();

        }

        public void mostrar_datos()
        {
            DgvPersonas.DataSource = null;
            DgvPersonas.Columns.Clear();
            DgvPersonas.DataSource = controller.get_personas();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DgvPersonas.Columns.Add(btn);
            btn.Text = "Editar";
            btn.Name = "Editar";
            btn.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            DgvPersonas.Columns.Add(btn1);
            btn1.Text = "Eliminar";
            btn1.Name = "Eliminar";
            btn1.UseColumnTextForButtonValue = true;
        }

        private void DgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(DgvPersonas.Columns[e.ColumnIndex].Name);
            if (DgvPersonas.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("Esta seguro de eliminar este Registro ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int indice = e.RowIndex;
                    if (controller.delete(indice))
                    {
                        mostrar_datos();
                        MessageBox.Show("Registro eliminado correctamente!");
                    }
                    else
                    {

                        MessageBox.Show("Registro eliminado correctamente!");
                    }
                }
                    //DgvPersonas.RemoveCurrent();
            }else if(DgvPersonas.Columns[e.ColumnIndex].Name == "Editar")
            {
                MessageBox.Show("Esta seguro de editar este Registro ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
            }
        }
    }
}