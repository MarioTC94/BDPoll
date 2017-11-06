﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Data {

    public class clsCatalogos {

        public DataTable getTipoPersona() {
            return new clsConnection().SelectData(new SqlCommand("SELECT a.IDTipoPersona, a.DescripcionTipoPersona, a.Activo FROM TipoPersona a WHERE Activo = 1;"));
        }

        public DataTable getTipoDireccion() {
            return new clsConnection().SelectData(new SqlCommand("SELECT a.IDTipoDireccion, a.DescripcionTipoTelefono, a.Activo FROM TipoDireccion a WHERE Activo = 1;"));
        }

        public DataTable getTipoEmail() {
            return new clsConnection().SelectData(new SqlCommand("SELECT a.IDTipoEmail, a.DescripcionTipoEmail, a.Activo FROM TipoEmail a WHERE Activo = 1;"));
        }

        public DataTable getTipoTelefono() {
            return new clsConnection().SelectData(new SqlCommand("SELECT a.IDTipoTelefono, a.DescripcionTipoTelefono, a.Activo FROM TipoTelefono a WHERE Activo = 1;"));
        }

        public DataTable getTipoPregunta() {
            return new clsConnection().SelectData(new SqlCommand("SELECT a.IDTipoPregunta, a.DescripcionTipoPregunta, a.Activo FROM TipoPregunta a WHERE Activo = 1;"));
        }

        public DataTable getTipoCuestionario() {
            return new clsConnection().SelectData(new SqlCommand("SELECT a.IDTipoCuestionario, a.DescripcionTipoPregunta, a.Activo FROM TipoCuestionario a WHERE Activo = 1;"));
        }

        public DataTable getCountry() {
            return new clsConnection().SelectData(new SqlCommand("SELECT a.IDCountry, a.SortName, a.NameCountry, a.PhoneCode, a.Active FROM Country a WHERE Active = 1;"));
        }

        public DataTable getState() {
            return new clsConnection().SelectData(new SqlCommand("SELECT a.IDState, a.NameState, a.IDCountry, a.Active FROM State a WHERE Active = 1;"));
        }

        public DataTable getCity() {
            return new clsConnection().SelectData(new SqlCommand("SELECT a.IDCity, a.NameCity, a.IDState, a.Active FROM City a WHERE Active = 1;"));
        }
    }
}
