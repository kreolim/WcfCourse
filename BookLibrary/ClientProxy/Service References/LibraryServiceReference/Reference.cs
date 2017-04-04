﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientProxy.LibraryServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/BookLibrary.Server")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PublishYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientProxy.LibraryServiceReference.BookType TypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PublishYear {
            get {
                return this.PublishYearField;
            }
            set {
                if ((this.PublishYearField.Equals(value) != true)) {
                    this.PublishYearField = value;
                    this.RaisePropertyChanged("PublishYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientProxy.LibraryServiceReference.BookType Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BookType", Namespace="http://schemas.datacontract.org/2004/07/BookLibrary.Server")]
    public enum BookType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Scientific = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Magazine = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ArtisticLiterature = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Other = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LibraryServiceReference.ILibraryService")]
    public interface ILibraryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/AddBook", ReplyAction="http://tempuri.org/ILibraryService/AddBookResponse")]
        void AddBook(ClientProxy.LibraryServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/AddBook", ReplyAction="http://tempuri.org/ILibraryService/AddBookResponse")]
        System.Threading.Tasks.Task AddBookAsync(ClientProxy.LibraryServiceReference.Book book);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBook", ReplyAction="http://tempuri.org/ILibraryService/GetBookResponse")]
        ClientProxy.LibraryServiceReference.Book GetBook(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBook", ReplyAction="http://tempuri.org/ILibraryService/GetBookResponse")]
        System.Threading.Tasks.Task<ClientProxy.LibraryServiceReference.Book> GetBookAsync(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBooks", ReplyAction="http://tempuri.org/ILibraryService/GetBooksResponse")]
        ClientProxy.LibraryServiceReference.Book[] GetBooks(string bookAuthor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/GetBooks", ReplyAction="http://tempuri.org/ILibraryService/GetBooksResponse")]
        System.Threading.Tasks.Task<ClientProxy.LibraryServiceReference.Book[]> GetBooksAsync(string bookAuthor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/TakeBook", ReplyAction="http://tempuri.org/ILibraryService/TakeBookResponse")]
        void TakeBook(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/TakeBook", ReplyAction="http://tempuri.org/ILibraryService/TakeBookResponse")]
        System.Threading.Tasks.Task TakeBookAsync(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/ReturnBook", ReplyAction="http://tempuri.org/ILibraryService/ReturnBookResponse")]
        void ReturnBook(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILibraryService/ReturnBook", ReplyAction="http://tempuri.org/ILibraryService/ReturnBookResponse")]
        System.Threading.Tasks.Task ReturnBookAsync(int bookId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILibraryServiceChannel : ClientProxy.LibraryServiceReference.ILibraryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibraryServiceClient : System.ServiceModel.ClientBase<ClientProxy.LibraryServiceReference.ILibraryService>, ClientProxy.LibraryServiceReference.ILibraryService {
        
        public LibraryServiceClient() {
        }
        
        public LibraryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddBook(ClientProxy.LibraryServiceReference.Book book) {
            base.Channel.AddBook(book);
        }
        
        public System.Threading.Tasks.Task AddBookAsync(ClientProxy.LibraryServiceReference.Book book) {
            return base.Channel.AddBookAsync(book);
        }
        
        public ClientProxy.LibraryServiceReference.Book GetBook(int bookId) {
            return base.Channel.GetBook(bookId);
        }
        
        public System.Threading.Tasks.Task<ClientProxy.LibraryServiceReference.Book> GetBookAsync(int bookId) {
            return base.Channel.GetBookAsync(bookId);
        }
        
        public ClientProxy.LibraryServiceReference.Book[] GetBooks(string bookAuthor) {
            return base.Channel.GetBooks(bookAuthor);
        }
        
        public System.Threading.Tasks.Task<ClientProxy.LibraryServiceReference.Book[]> GetBooksAsync(string bookAuthor) {
            return base.Channel.GetBooksAsync(bookAuthor);
        }
        
        public void TakeBook(int bookId) {
            base.Channel.TakeBook(bookId);
        }
        
        public System.Threading.Tasks.Task TakeBookAsync(int bookId) {
            return base.Channel.TakeBookAsync(bookId);
        }
        
        public void ReturnBook(int bookId) {
            base.Channel.ReturnBook(bookId);
        }
        
        public System.Threading.Tasks.Task ReturnBookAsync(int bookId) {
            return base.Channel.ReturnBookAsync(bookId);
        }
    }
}
