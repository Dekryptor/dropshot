﻿using System.ServiceModel;

namespace Dropshot.WebServices {
	[ServiceContract]
	public interface IRelationshipWebServiceContract {
		[OperationContract]
		byte[] SendContactRequest(byte[] data);

		[OperationContract]
		byte[] GetContactRequests(byte[] data);

		[OperationContract]
		byte[] AcceptContactRequest(byte[] data);

		[OperationContract]
		byte[] DeclineContactRequest(byte[] data);

		[OperationContract]
		byte[] DeleteContact(byte[] data);

		[OperationContract]
		byte[] GetContactsByGroups(byte[] data);
	}
}