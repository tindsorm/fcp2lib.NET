/*
 *  The FCP2.0 Library, complete access to freenets FCP 2.0 Interface
 * 
 *  Copyright (c) 2009-2014 Thomas Bruderer <apophis@apophis.ch>
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace FCP2
{

    public class PersistentPutEventArgs : System.EventArgs
    {
        readonly string clientToken;
        readonly long dataLength;
        readonly string filename;
        readonly bool global;
        readonly long maxRetries;
        readonly MetadataType metadata;
        readonly PriorityClassEnum priorityClass;
        readonly string targetFilename;
        readonly UploadFromEnum uploadFrom;
        readonly string uri;
        readonly VerbosityEnum verbosity;

        /// <summary>
        /// PersistentPutEventArgs Constructor
        /// </summary>
        /// <param name="parsed">a simple MessageParse</param>
        internal PersistentPutEventArgs(dynamic parsed)
        {
#if DEBUG
            FCP2Protocol.ArgsDebug(this, parsed);
#endif

            uri = parsed.URI;
            verbosity = parsed.Verbosity;
            priorityClass = parsed.PriorityClass;
            uploadFrom =parsed.UploadFrom;
            filename = parsed.Filename;
            targetFilename = parsed.TargetFilename;
            metadata = new MetadataType(parsed.Metadata);
            clientToken = parsed.ClientToken;
            global = parsed.Global;
            dataLength = parsed.DataLength;
            maxRetries = parsed.MaxRetries;

#if DEBUG
            parsed.PrintAccessCount();
#endif
        }

        public string URI
        {
            get { return uri; }
        }

        public VerbosityEnum Verbosity
        {
            get { return verbosity; }
        }

        public PriorityClassEnum PriorityClass
        {
            get { return priorityClass; }
        }

        public UploadFromEnum UploadFrom
        {
            get { return uploadFrom; }
        }

        public string Filename
        {
            get { return filename; }
        }

        public string TargetFilename
        {
            get { return targetFilename; }
        }

        public MetadataType Metadata
        {
            get { return metadata; }
        }

        public string ClientToken
        {
            get { return clientToken; }
        }

        public bool Global
        {
            get { return global; }
        }

        public long DataLength
        {
            get { return dataLength; }
        }

        public long MaxRetries
        {
            get { return maxRetries; }
        }

        #region Nested type: MetadataType

        public class MetadataType
        {
            readonly string contentType;

            internal MetadataType(dynamic metadata)
            {
                contentType = metadata.ContentType;
            }

            public string ContentType
            {
                get { return contentType; }
            }
        }

        #endregion
    }
}