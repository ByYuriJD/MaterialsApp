using System;
using System.Collections.Generic;

namespace MaterialsApp.Models;

public partial class OrganizationType {
	public short Id { get; set; }

	public string TypeOfPartner { get; set; } = null!;

	public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();

	public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
