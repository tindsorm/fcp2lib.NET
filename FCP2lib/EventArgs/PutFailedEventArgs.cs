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

    public class PutFailedEventArgs : System.EventArgs
    {

        readonly long code;
        readonly string codeDescription;
        readonly string expectedURI;
        readonly string extraDescription;
        readonly bool fatal;
        readonly bool global;
        readonly string identifier;
        readonly string shortCodeDescription;

        /// <summary>
        /// PutFailedEventArgs Constructor
        /// </summary>
        /// <param name="parsed">a simple MessageParse</param>
        internal PutFailedEventArgs(dynamic parsed)
        {
#if DEBUG
            FCP2Protocol.ArgsDebug(this, parsed);
#endif

            code = parsed.Code;
            identifier = parsed.identifier;
            global = parsed.Global;
            expectedURI = parsed.ExpectedURI;
            codeDescription = parsed.CodeDescription;
            extraDescription = parsed.ExtraDescription;
            fatal = parsed.Fatal;
            shortCodeDescription = parsed.ShortCodeDescription;

            /* TODO: Complex Put Failed */

#if DEBUG
            parsed.PrintAccessCount();
#endif
        }

        public string ShortCodeDescription
        {
            get { return shortCodeDescription; }
        }

        public string Identifier
        {
            get { return identifier; }
        }

        public bool Global
        {
            get { return global; }
        }

        public bool Fatal
        {
            get { return fatal; }
        }

        public string ExtraDescription
        {
            get { return extraDescription; }
        }

        public string ExpectedURI
        {
            get { return expectedURI; }
        }

        public string CodeDescription
        {
            get { return codeDescription; }
        }

        public long Code
        {
            get { return code; }
        }
    }
}