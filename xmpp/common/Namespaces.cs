// Namespaces.cs
//
//Ubiety XMPP Library Copyright (C) 2006 - 2009 Dieter Lunn
//
//This library is free software; you can redistribute it and/or modify it under
//the terms of the GNU Lesser General Public License as published by the Free
//Software Foundation; either version 3 of the License, or (at your option)
//any later version.
//
//This library is distributed in the hope that it will be useful, but WITHOUT
//ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
//FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public License for more
//
//You should have received a copy of the GNU Lesser General Public License along
//with this library; if not, write to the Free Software Foundation, Inc., 59
//Temple Place, Suite 330, Boston, MA 02111-1307 USA

namespace ubiety.common
{
    /// <summary>
    /// 
    /// </summary>
	public class Namespaces
	{
		public const string XMLNS = "http://www.w3.org/2000/xmlns";
		public const string XML = "http://www.w3.org/XML/1998/namespace";
		
		public const string CLIENT = "jabber:client";
        /// <summary>
        /// Stream Namespace - http://etherx.jabber.org/streams
        /// </summary>
		public const string STREAM = "http://etherx.jabber.org/streams";

        public const string XMPP_STREAMS = "urn:ietf:params:xml:ns:xmpp-streams";
        /// <summary>
        /// 
        /// </summary>
		public const string START_TLS = "urn:ietf:params:xml:ns:xmpp-tls";
        /// <summary>
        /// 
        /// </summary>
		public const string SASL = "urn:ietf:params:xml:ns:xmpp-sasl";
        /// <summary>
        /// 
        /// </summary>
		public const string AUTH = "http://jabber.org/features/iq-auth";
        /// <summary>
        /// 
        /// </summary>
		public const string REGISTER = "http://jabber.org/features/iq-register";
		
		public const string BIND = "urn:ietf:params:xml:ns:xmpp-bind";
		public const string SESSION = "urn:ietf:params:xml:ns:xmpp-session";
		
		public const string COMPRESSION = "http://jabber.org/features/compress";
		public const string COMPRESSION_PROTOCOL = "http://jabber.org/protocol/compress";

		public const string STANZAS = "urn:ietf:params:xml:ns:xmpp-stanzas";

        public const string ROSTVER = "urn:xmpp:features:rosterver";
	}
}
