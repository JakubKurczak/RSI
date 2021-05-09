using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

//http://localhost:56384/Service1.svc
namespace WcfService1
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IService1” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IRestService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        Book GetDataUsingDataContract(Book composite);

        [OperationContract]
        [WebGet(UriTemplate = "/Books")]
        List<Book> getAllXml();

        [OperationContract]
        [WebGet(UriTemplate = "/json/Books")]
        List<Book> getAllJson();

        [OperationContract]
        [WebGet(UriTemplate = "/Books/{id}", ResponseFormat = WebMessageFormat.Xml)]
        Book getByIdXml( string Id);

        [OperationContract]
        [WebGet(UriTemplate = "/json/Books/{id}", ResponseFormat = WebMessageFormat.Json)]
        Book getByIdJson(string Id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Books/{id}", Method = "PUT", RequestFormat = WebMessageFormat.Xml)]
        string updateByIdXml(string Id, Book book);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/Books/{id}", Method = "PUT", RequestFormat = WebMessageFormat.Json)]
        string updateByIdJson(string Id, Book book);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Books/borrow/{id}", Method = "PUT", RequestFormat = WebMessageFormat.Xml)]
        string borrowBookXml(string Id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/Books/borrow/{id}", Method = "PUT", RequestFormat = WebMessageFormat.Json)]
        string borrowBookJson(string Id);


        [OperationContract]
        [WebInvoke(UriTemplate = "/Books", Method = "POST", RequestFormat =WebMessageFormat.Xml)]
        string addXml(Book book);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/Books", Method = "POST", RequestFormat = WebMessageFormat.Json)]
        string addJson(Book book);

        [OperationContract]
        [WebInvoke(UriTemplate = "/Books/{id}", Method = "DELETE")]
        string deleteXml(string Id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/json/Books/{id}", Method = "DELETE")]
        string deleteJson(string Id);
        // TODO: dodaj tutaj operacje usługi
    }



    // Użyj kontraktu danych, jak pokazano w poniższym przykładzie, aby dodać typy złożone do operacji usługi.
    [DataContract]
    public class Book
    {
        static int idCounter = 0;
        public int id = 0;
        bool isBorrow = false;
        string title = "";
        string author = "";
        int pages = 0;

        public Book( string title, string author, int pages)
        {
            this.id = idCounter;
            idCounter++;
            this.Author = author;
            this.Pages = pages;
            this.Title = title;
        }

        [DataMember(Order = 0)]
        public bool IsBorrow
        {
            get { return isBorrow; }
            set { isBorrow = value; }
        }

        [DataMember(Order = 1)]
        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        [DataMember(Order = 2)]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        [DataMember(Order = 3)]
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
    }

}

