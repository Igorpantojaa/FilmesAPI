using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DTOs;

public class CreateFilmeDTO
{
    [Required(ErrorMessage = "O títiulo do filme é obrigatório.")]
    [StringLength(50, ErrorMessage = "O título do filme não pode exceder o limite de 50 caracteres.")]
    public string? Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório.")]
    [MaxLength(50, ErrorMessage = "O gênero do filme não pode exceder o limite de 50 caracteres.")]
    public string? Genero { get; set; }
    [Required(ErrorMessage = "A duração do filme é obrigatória.")]
    [Range(1, 360, ErrorMessage = "A duração do filme deve ser entre 1 e 360 minutos.")]
    public int Duracao { get; set; }
}
