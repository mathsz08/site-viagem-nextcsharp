using System.ComponentModel.DataAnnotations.Schema;

namespace Usuarios.Model{
    
     [Table("Usuarios")]
  public class Usuario
  {



    [Column("id")]
        public int Id {get; set;}

        [Column("usuario_login")]
        public string Login {get; set;}

        [Column("usuario_senha")]
        public string Senha {get; set;}

        [Column("usuario_cpf")]
        public string Cpf {get;set;}

        [Column("usuario_nome")]
        public string nome {get;set;}

        [Column("usuario_data_nascimento")]
        public string data_nascimento {get;set;}

        [Column("usuario_url")]
        public string usuarioURL{get;set;}



  }
}