namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("59387b68-6cca-4d87-9016-b873eec0a4b4");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6aefb788-a848-4667-931e-b7aea249f537");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,81,107,219,48,16,126,47,244,63,28,126,178,33,136,246,117,237,10,115,200,74,161,108,165,113,247,50,246,160,200,23,87,67,150,140,78,78,155,150,253,247,157,44,103,73,157,14,122,24,44,157,190,251,238,190,143,179,178,69,234,164,66,168,208,123,73,110,29,196,220,217,181,110,122,47,131,118,246,244,228,245,244,4,56,122,210,182,129,229,150,2,182,23,135,169,195,194,182,117,246,191,143,30,197,194,6,29,52,210,71,48,98,177,65,27,118,208,159,67,122,59,228,110,53,15,97,209,231,75,245,136,173,252,198,26,224,51,100,15,228,239,81,154,176,205,138,95,169,168,235,87,70,43,80,70,18,65,122,123,135,6,62,65,41,9,223,121,73,44,163,1,7,132,110,195,35,235,26,97,227,116,13,223,237,82,110,88,72,238,86,191,81,5,32,180,53,250,25,36,194,18,215,172,106,160,253,226,27,2,44,246,116,7,204,49,86,60,133,248,199,182,163,193,226,226,45,44,241,130,31,244,176,240,60,37,138,84,48,1,215,168,116,43,13,116,94,171,232,82,170,18,215,24,170,109,135,245,220,153,190,181,63,164,233,241,114,132,94,229,209,201,187,136,207,166,173,245,26,242,196,116,5,231,103,187,40,222,130,38,170,98,160,184,161,185,180,10,13,214,60,68,240,61,50,243,49,142,130,143,27,193,59,73,178,193,10,219,206,200,16,199,182,248,4,183,78,73,163,95,228,202,224,114,192,229,163,152,7,66,207,75,107,217,124,222,88,113,143,228,122,175,24,228,60,179,204,142,219,196,216,175,75,218,179,108,6,217,81,7,18,131,53,55,84,57,87,234,38,221,178,66,84,110,156,160,248,128,12,30,63,37,196,87,231,91,25,242,137,60,110,124,46,206,74,184,46,239,142,12,143,17,30,189,123,26,28,88,60,43,236,162,198,29,197,20,254,103,127,29,143,252,227,239,47,34,101,126,13,231,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("907fe9a0-d426-f0a8-bde9-9c05b91b3629"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("6aefb788-a848-4667-931e-b7aea249f537"),
				CreatedInSchemaUId = new Guid("59387b68-6cca-4d87-9016-b873eec0a4b4"),
				ModifiedInSchemaUId = new Guid("59387b68-6cca-4d87-9016-b873eec0a4b4")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("59387b68-6cca-4d87-9016-b873eec0a4b4"));
		}

		#endregion

	}

	#endregion

}

