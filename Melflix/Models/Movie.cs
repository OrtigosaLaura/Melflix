using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melflix.Models;

[Table("Movie")]
 public class Movie
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public uint Id { get; set; }
       [Display(Name = "Título Original")]
       [Required(ErrorMessage = "Por favor, informe o Título Original")]
       [StringLength(100, ErrorMessage = "O Título Original deve possuir no máximo 100 caracteres")]

       public string OriginalTitle { get; set; }
       [Display(Name = "Título Original")]
       [Required(ErrorMessage = "Por favor, informe o Título Original")]
       [StringLength(100, ErrorMessage = "O Título Original deve possuir no máximo 100 caracteres")]

       public string  Title { get; set; }
       [Display(Name = "Resumo")]
       [StringLength(8000, ErrorMessage = "O Resumo deve possuir no máximo 8000")]

       public string Synopsis { get; set; }
       [Column(TypeName = "Year")]
       public Int16 MovieYear { get; set; }

       public Int16 Duration { get; set; }

       public byte AgeRating { get; set; }

       public string Image { get; set; }
    }