using System.ComponentModel.DataAnnotations;

namespace DropdownlistWithEnum.Models
{
    public class MusicProfileViewModel
    {
        public int Id { get; set; }

        [Display(Name = "My favourite music type")]
        public MusicGenreEnum MusicGenre { get; set; }
    }
}