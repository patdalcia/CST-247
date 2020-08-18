using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BenchmarkBibleVerseApp.Models
{
    public class VerseSearchModel
    {
        [DisplayName("Book Name: ")]
        [Required(AllowEmptyStrings = false)]
        [MaxLength(15, ErrorMessage = "Book Name can only be 15 characters long")]
        public String BookName { get; set; }

        [DisplayName("Chapter Number: ")]
        [Required]
        public int ChapterNumber { get; set; }

        [DisplayName("Verse Number: ")]
        [Required]
        public int VerseNumber { get; set; }

        public VerseSearchModel()
        {

        }

        public VerseSearchModel(String bookname, int chapternumber, int versenumber)
        {
            this.BookName = bookname;
            this.ChapterNumber = chapternumber;
            this.VerseNumber = versenumber;
        }
    }
}