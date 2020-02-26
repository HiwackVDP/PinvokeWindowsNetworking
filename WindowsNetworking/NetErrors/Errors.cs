namespace WindowsNetworking.NetErrors
{
	public static class Errors
	{
		public const int NoError = 0;

		public const int AccessDenied = 5;
		public const int AlreadyAssigned = 85;
		public const int BadDevice = 1200;
		public const int BadNetName = 67;
		public const int BadProvider = 1204;
		public const int Cancelled = 1223;
		public const int ExtendedError = 1208;
		public const int InvalidAddress = 487;
		public const int InvalidParameter = 87;
		public const int InvalidPassword = 1216;
		public const int MoreData = 234;
		public const int NoMoreItems = 259;
		public const int NoNetOrBadPath = 1203;
		public const int NoNetwork = 1222;

		public const int BadProfile = 1206;
		public const int CannotOpenProfile = 1205;
		public const int DeviceInUse = 2404;
		public const int NotConnected = 2250;
		public const int OpenFiles = 2401;
		public const int MultipleUserConnections = 1219;

		// Created with excel formula:
		// ="new ErrorClass("&A1&", """&PROPER(SUBSTITUTE(MID(A1,7,LEN(A1)-6), "_", " "))&"""), "
		public static ErrorClass[] ErrorList = new ErrorClass[] {
			new ErrorClass(AccessDenied, "Error: Access Denied"),
			new ErrorClass(AlreadyAssigned, "Error: Already Assigned"),
			new ErrorClass(BadDevice, "Error: Bad Device"),
			new ErrorClass(BadNetName, "Error: Bad Net Name"),
			new ErrorClass(BadProvider, "Error: Bad Provider"),
			new ErrorClass(Cancelled, "Error: Cancelled"),
			new ErrorClass(ExtendedError, "Error: Extended Error"),
			new ErrorClass(InvalidAddress, "Error: Invalid Address"),
			new ErrorClass(InvalidParameter, "Error: Invalid Parameter"),
			new ErrorClass(InvalidPassword, "Error: Invalid Password"),
			new ErrorClass(MoreData, "Error: More Data"),
			new ErrorClass(NoMoreItems, "Error: No More Items"),
			new ErrorClass(NoNetOrBadPath, "Error: No Net Or Bad Path"),
			new ErrorClass(NoNetwork, "Error: No Network"),
			new ErrorClass(BadProfile, "Error: Bad Profile"),
			new ErrorClass(CannotOpenProfile, "Error: Cannot Open Profile"),
			new ErrorClass(DeviceInUse, "Error: Device In Use"),
			new ErrorClass(NotConnected, "Error: Not Connected"),
			new ErrorClass(OpenFiles, "Error: Open Files"),
			new ErrorClass(MultipleUserConnections, "Error: Multiple User Connections"),
		};

		public static string GetErrorForNumber(int errNum)
		{
			foreach (ErrorClass er in ErrorList)
			{
				if (er.num == errNum) return er.message;
			}
			return "Error: Unknown, " + errNum;
		}
	}
}