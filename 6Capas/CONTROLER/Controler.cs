﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITIES;
using BLL;
using INTERFACES;


namespace CONTROLER
{
    public class ControlerUi:Iabmc
    {
        Form UiForm;
        BllPersona PersonaBll;
        int ClickVeces=0;

        public ControlerUi(Form uiForm)
        {
            UiForm = uiForm;
            PersonaBll = new BllPersona();// UIpersona-->Bllpersona
        }

        public void Alta()
        {
            try
            {
                EntityPersona PersonaEntity = new EntityPersona(
                UiForm.Controls["textBoxDni"].Text,
                UiForm.Controls["textBoxNombre"].Text,
                UiForm.Controls["textBoxApellido"].Text);

                PersonaBll.Alta(PersonaEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Baja()
        {
            EntityPersona PersonaEntity = (UiForm.Controls["dataGridView1"] as DataGridView).SelectedRows[0].DataBoundItem as EntityPersona;
            PersonaBll.Baja(PersonaEntity);
        }

        public void Consulta()
        {
            throw new NotImplementedException();
        }

        public void ConsultaTodos()
        {        
            (UiForm.Controls["dataGridView1"] as DataGridView).DataSource = null;
            (UiForm.Controls["dataGridView1"] as DataGridView).DataSource = PersonaBll.ConsultaTodos();
        }

        public void Modificacion()
        {
            try
            {
                EntityPersona PersonaEntitySeleccionada = (UiForm.Controls["dataGridView1"] as DataGridView).SelectedRows[0].DataBoundItem as EntityPersona;
                EntityPersona PersonaEntityModificada = new EntityPersona(
                UiForm.Controls["textBoxDni"].Text,
                UiForm.Controls["textBoxNombre"].Text,
                UiForm.Controls["textBoxApellido"].Text);
                
                PersonaBll.Modificacion(PersonaEntitySeleccionada, PersonaEntityModificada);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void CargarTextBox()
        {
            EntityPersona PersonaEntitySeleccionada = (UiForm.Controls["dataGridView1"] as DataGridView).SelectedRows[0].DataBoundItem as EntityPersona;
            UiForm.Controls["textBoxDni"].Text = PersonaEntitySeleccionada.Dni;
            UiForm.Controls["textBoxNombre"].Text = PersonaEntitySeleccionada.Nombre;
            UiForm.Controls["textBoxApellido"].Text = PersonaEntitySeleccionada.Apellido;
        }
        public void MostrarEnDGV()
        {
               
        }
    }
}
