using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Verlag;

namespace VerlagTests
{
	[TestClass]
	public class BuchTests
	{
		[TestMethod]
		public void Buch_KannErstelltWerden()
		{
			//Arrange
			string autor = "J.K. Rowling";
			string titel = "Harry Potter und der Gefangene von Askaban";
			int auflage = 1;

			//Act 
			Buch b = new Buch(autor, titel, auflage);

			//Assert
			Assert.AreEqual(autor, b.Autor);
			Assert.AreEqual(titel, b.Titel);
			Assert.AreEqual(auflage, b.Auflage);
		}

		[TestMethod]
		public void Buch_KeineAuflageEntsprichtErsterAuflage()
		{
			//Arrange

			//Act 
			Buch b = new Buch("autor", "titel");

			//Assert
			Assert.AreEqual(1, b.Auflage);
		}

		[TestMethod]
		public void Autor_DarfVeraendertWerden()
		{
			//Arrange
			string autor = "Abdullah";
			string autorNeu = "Thomas";

			//Act
			Buch b = new Buch(autor, "titel");
			b.Autor = autorNeu;

			//Assert
			Assert.AreEqual(autorNeu, b.Autor);

		}

		[TestMethod]
		public void Auflage_DarfVeraendertWerden()
		{
			//Arrange
			int auflage = 15;
			int auflageNeu = 42;

			//Act
			Buch b = new Buch("autor", "titel", auflage);
			b.Auflage = auflageNeu;

			//Assert
			Assert.AreEqual(auflageNeu, b.Auflage);

		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Buch_AuflageDarfNichtZuKleinSein()
		{
			//Arrange
			int auflage = 0;

			//Act
			Buch b = new Buch("autor", "titel", auflage);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void Auflage_DarfNichtZuKleinSein()
		{
			//Arrange
			Buch b = new Buch("autor", "titel");
			int auflageNeu = 0;

			//Act
			b.Auflage = auflageNeu;
		}

		// DataRow: https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest#add-more-features
		[TestMethod]
		[DataRow("")]
		[DataRow("#")]
		[DataRow(";")]
		[DataRow("�")]
		[DataRow("%")]
		[DataRow(null)]
		[ExpectedException(typeof(ArgumentException))]
		public void Autor_NurSinnvolleEingabenErlaubt(string unerlaubtesZeichen)
		{
			//Act
			Buch b = new Buch(unerlaubtesZeichen, "titel");
		}





		//[TestMethod]
		//      public void ISBN_KannErgaenztWerden()
		//      {
		//          //Arrange
		//          string isbn = "978-3770436163";
		//	Buch b = new Buch("autor", "titel");

		//	//Act
		//	b.ISBN = isbn;

		//	//Assert
		//	Assert.AreEqual(isbn, b.ISBN);
		//}

		//[TestMethod]
		//public void ISBN_FehltPruefziffer_KorrekturFallsNoetig()
		//{
		//	//Arrange
		//	string isbnOhnePruefziffer = "978-3-431-07055";
		//	string isbn13MitPruefziffer = "9783431070552";
		//	Buch b = new Buch("autor", "titel");

		//	//Act
		//	b.ISBN = isbnOhnePruefziffer;

		//	//Assert
		//	Assert.AreEqual(isbn13MitPruefziffer, b.ISBN13);

		//}

		//[TestMethod]
		//public void ISBN_KannAusISBN13BerechnetWerden()
		//{
		//	//Arrange
		//	string isbn13 = "9783431070552";
		//	string isbn = "978-3-431-070552";

		//	Buch b = new Buch("autor", "titel");
		//	b.ISBN = isbn13;

		//	//Act
		//	string result = b.ISBN13;

		//	//Assert
		//	Assert.AreEqual(isbn, result);


		//}








	}
}
