using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TrabalhoFinalGitHub.Models;
using TrabalhoFinalGitHub.Utilities;
using Xamarin.Forms;

namespace TrabalhoFinalGitHub.Daos
{

    public class UsuarioDao : IDisposable
    {

        private SQLiteConnection conn;

        public UsuarioDao()
        {
            GetConnection();
        }

        public void GetConnection()
        {
            var cfg = DependencyService.Get<IConfigPlatform>();
            conn = new SQLiteConnection(cfg.PlatformDB, Path.Combine(cfg.PathDB, "AppGitHubUsuario.db"));

            conn.CreateTable<UsuarioModel>();

        }

        public void InsertUsuario(UsuarioModel usuario)
        {
            conn.Insert(usuario);
        }

        public void UpdateUsuario(UsuarioModel usuario)
        {
            conn.Update(usuario);
        }

        public void DeleteUsuario(UsuarioModel usuario)
        {
            conn.Delete(usuario);
        }

        public UsuarioModel FindOneUsuario(int idUsuario)
        {
            return conn.Table<UsuarioModel>().FirstOrDefault(u => u.Id == idUsuario);
        }

        public List<UsuarioModel> FindAllUsuario()
        {
            return conn.Table<UsuarioModel>().OrderBy(u => u.Nome).ToList();
        }

        public void Dispose()
        {
            conn.Dispose();
        }

    }

}
