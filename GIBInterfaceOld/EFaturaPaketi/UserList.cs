﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1590.0.
// 
namespace GIBInterfaceOld.EFaturaPaketi
{
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class UserList
    {

        private User[] userField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("User", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public User[] User
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class User
    {

        private string identifierField;

        private string titleField;

        private UsrType typeField;

        private string firstCreationTimeField;

        private AccType accountTypeField;

        private bool accountTypeFieldSpecified;

        private DocumentType[] documentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UsrType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string FirstCreationTime
        {
            get
            {
                return this.firstCreationTimeField;
            }
            set
            {
                this.firstCreationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AccType AccountType
        {
            get
            {
                return this.accountTypeField;
            }
            set
            {
                this.accountTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccountTypeSpecified
        {
            get
            {
                return this.accountTypeFieldSpecified;
            }
            set
            {
                this.accountTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Document", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public DocumentType[] Documents
        {
            get
            {
                return this.documentsField;
            }
            set
            {
                this.documentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
    [System.SerializableAttribute()]
    public enum UsrType
    {

        /// <remarks/>
        OZEL,

        /// <remarks/>
        KAMU,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
    [System.SerializableAttribute()]
    public enum AccType
    {

        /// <remarks/>
        GIBPORTAL,

        /// <remarks/>
        ENTEGRASYON,

        /// <remarks/>
        OZELENTEGRASYON,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DocumentType
    {

        private AliasType[] aliasField;

        private DocType typeField;

        private bool typeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alias", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public AliasType[] Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DocType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AliasType
    {

        private string[] nameField;

        private string creationTimeField;

        private string deletionTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Name", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string[] Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string CreationTime
        {
            get
            {
                return this.creationTimeField;
            }
            set
            {
                this.creationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string DeletionTime
        {
            get
            {
                return this.deletionTimeField;
            }
            set
            {
                this.deletionTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
    [System.SerializableAttribute()]
    public enum DocType
    {

        /// <remarks/>
        Invoice,

        /// <remarks/>
        DespatchAdvice,
    }
}