using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BenchmarkBibleVerseApp.Models
{
    public class VerseEntryModel
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

        [DisplayName("Verse Text: ")]
        [Required(AllowEmptyStrings = false)]
        [MaxLength(200, ErrorMessage = "Verse Text can only be 200 characters long")]
        public String VerseText { get; set; }

        public VerseEntryModel() { }

        public VerseEntryModel(String bookname, int chapternumber, int versenumber, String versetext)
        {
            this.BookName = bookname;
            this.ChapterNumber = chapternumber;
            this.VerseNumber = versenumber;
            this.VerseText = versetext;
        }             
    }
}