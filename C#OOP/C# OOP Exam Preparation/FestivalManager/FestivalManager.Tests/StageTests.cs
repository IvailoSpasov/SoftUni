
namespace FestivalManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
	public class StageTests
    {
		

        [Test]
        public void AddPerformerMethodShouldThrowExceptionWhenObjIsNull()
        {
            Stage stage = new Stage();
            Performer performer = null;
            Assert.Throws<ArgumentNullException>(() => stage.AddPerformer(performer));
        }

        [Test]
        public void AddPerformerMethodShouldThrowExceptionWhenPerformerAgeIsUnder18()
        {
            Stage stage = new Stage();
            Performer performer = new Performer("Gogo", "Gogov",12);
            Assert.Throws<ArgumentException>(() => stage.AddPerformer(performer));
        }

        [Test]
        public void AddPerformerMethodShouldWork()
        {
            Stage stage = new Stage();
            Performer performer = new Performer("Gogo", "Gogov", 18);
            stage.AddPerformer(performer);
            Assert.AreEqual(1,stage.Performers.Count);
        }

        [Test]
        public void AddSongShouldThrowExceptionWhenSongIsNull()
        {
            Stage stage = new Stage();
            Song song = null;
            Assert.Throws<ArgumentNullException>(()=>stage.AddSong(song));
        }
        [Test]
        public void AddSongShouldThrowExceptionWhenSongDurationIsBelowMinute()
        {
            Stage stage = new Stage();
            TimeSpan duration = new TimeSpan(0, 0, 59);
            Song song = new Song("song", duration);
            Assert.Throws<ArgumentException>(() => stage.AddSong(song));
        }

        [Test]
        public void AddSongToPerformerShouldThrowExceptionWhenSongNameIsNull()
        {
            Stage stage = new Stage();
            string song = null;
            string performer = "gogo";
            Assert.Throws<ArgumentNullException>((() => stage.AddSongToPerformer(song, performer)));
        }
        [Test]
        public void AddSongToPerformerShouldThrowExceptionWhenPerformerNameIsNull()
        {
            Stage stage = new Stage();
            string song = "song";
            string performer = null;
            Assert.Throws<ArgumentNullException>((() => stage.AddSongToPerformer(song, performer)));
        }
        [Test]
        public void AddSongToPerformerShouldWorkProperly()
        {
            Stage stage = new Stage();
            TimeSpan duration = new TimeSpan(0, 1, 59);
            Song song = new Song("song", duration);
            stage.AddSong(song);
            Performer performer = new Performer("Gogo", "Gogov", 18);
            stage.AddPerformer(performer);
            string result = stage.AddSongToPerformer("song", "Gogo Gogov");
            
            Assert.AreEqual("song (01:59) will be performed by Gogo Gogov",result);
        }
        [Test]
        public void PlaySongToPerformerShouldWorkProperly()
        {
            Stage stage = new Stage();
            TimeSpan duration = new TimeSpan(0, 1, 59);
            Song song = new Song("song", duration);
            stage.AddSong(song);
            Performer performer = new Performer("Gogo", "Gogov", 18);
            stage.AddPerformer(performer);
            stage.AddSongToPerformer("song", "Gogo Gogov");
            string result = stage.Play();

            Assert.AreEqual("1 performers played 1 songs", result);
        }

        [Test]
        public void AddSongToPerformerShouldThrowExceptionWhenPerformerNameIsWrong()
        {
            Stage stage = new Stage();
            TimeSpan duration = new TimeSpan(0, 1, 59);
            Song song = new Song("song", duration);
            stage.AddSong(song);
            Performer performer = new Performer("Gogo", "Gogov", 18);
            stage.AddPerformer(performer);
            Assert.Throws<ArgumentException>((() => stage.AddSongToPerformer("song", "petko")));
        }
        [Test]
        public void AddSongToPerformerShouldThrowExceptionWhenSongNameIsWrong()
        {
            Stage stage = new Stage();
            TimeSpan duration = new TimeSpan(0, 1, 59);
            Song song = new Song("song", duration);
            stage.AddSong(song);
            Performer performer = new Performer("Gogo", "Gogov", 18);
            stage.AddPerformer(performer);
            Assert.Throws<ArgumentException>((() => stage.AddSongToPerformer("Pesen", "Gogo Gogov")));
        }
    }
}