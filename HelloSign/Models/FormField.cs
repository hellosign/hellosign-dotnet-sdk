namespace HelloSign
{
    public class FormField
    {
        // Constants for type property
        public const string TypeText = "text";
        public const string TypeCheckbox = "checkbox";
        public const string TypeDateSigned = "date_signed";
        public const string TypeInitials = "initials";
        public const string TypeSignature = "signature";

        // Constants for validation_type property
        public const string ValidationTypeNumbersOnly = "numbers_only";
        public const string ValidationTypeLettersOnly = "letters_only";
        public const string ValidationTypePhoneNumber = "phone_number";
        public const string ValidationTypeBankRoutingNumber = "bank_routing_number";
        public const string ValidationTypeBankAccountNumber = "bank_account_number";
        public const string ValidationTypeEmailAddress = "email_address";
        public const string ValidationTypeZipCode = "zip_code";
        public const string ValidationTypeSocialSecurityNumber = "social_security_number";
        public const string ValidationTypeEmployerIdentificationNumber = "employer_identification_number";

        // Field names don't follow normal naming convention here so we can serialize these to JSON more easily later.
        // Consumers should just be using the constructor to set these.
        public string api_id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool required { get; set; }
        public int signer { get; set; }
        public int file { get; set; }
        public int page { get; set; }
        public string validation_type { get; set; }

        public FormField() { }

        /// <summary>
        /// Create a new Form Field, for use with file-based Signature Requests where you wish to specify signer fields
        /// explicitly.
        /// </summary>
        /// <param name="apiId">A unique identifier for this field, for use when retrieving response data after signing.</param>
        /// <param name="type">Type of this fieldfields See FormField.Type* constants.</param>
        /// <param name="page">Page number this field appears on in this file.</param>
        /// <param name="x">X position from the left of the page. 72 = 1 inch.</param>
        /// <param name="y">Y position from the top of the page. 72 = 1 inch.</param>
        /// <param name="width">Width of this field. 72 = 1 inch.</param>
        /// <param name="height">Height of this field. 72 = 1 inch.</param>
        /// <param name="required">Whether the signer is required to fill out this field.</param>
        /// <param name="signer">Index of the signer this field is assigned to, starting from 0.</param>
        /// <param name="validationType">Optional validation rule for use with text fields. See FormField.ValidationType* constants.</param>
        public FormField(string apiId, string type, int page, int x, int y, int width, int height, bool required, int signer, string validationType = null)
        {
            this.api_id = apiId;
            this.type = type;
            this.page = page;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.required = required;
            this.signer = signer;
            this.validation_type = validationType;
        }
    }
}