﻿using System.Collections.ObjectModel;
using System.Windows.Input;
using TrabalhoFinalGitHub.Daos;
using TrabalhoFinalGitHub.Models;

namespace TrabalhoFinalGitHub.ViewModels
{
    class UsuarioViewModel
    {
        public ICommand SalvarUsuario { get; set; }

        public ObservableCollection<Models.UsuarioModel> Usuarios { get; set; }

        public UsuarioViewModel()
        {
            Usuarios = new ObservableCollection<Models.UsuarioModel>();

            // Obtem os usuario cadastrados no SQLite
            var listaUsuarios = new UsuarioDao().FindAllUsuario();
            foreach(UsuarioModel user in listaUsuarios)
            {
                Usuarios.Add(user);
            }

            SalvarUsuario = new Xamarin.Forms.Command(() =>
            {
                UsuarioModel usuarioModel = new UsuarioModel();
                usuarioModel.Id = 0; // Autoincrement no tabela
                usuarioModel.Nome = "IMPLEMENTAR...";
            
                new UsuarioDao().InsertUsuario(usuarioModel);
                Usuarios.Add(usuarioModel);
            });

        }

    }
}
