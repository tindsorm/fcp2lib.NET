﻿/*
 *  The FCP2.0 Library, complete access to freenets FCP 2.0 Interface
 * 
 *  Copyright (c) 2009 Thomas Bruderer <apophis@apophis.ch>
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
 
using System;

namespace Freenet.FCP2 {

    public class PutFetchableEventArgs : EventArgs {

        private bool global;
        
        public bool Global {
            get { return global; }
        }
        
        private string identifier;
        
        public string Identifier {
            get { return identifier; }
        }
        
        private string uri;
        
        public string URI {
            get { return uri; }
        }        
        
        /// <summary>
        /// PutFetchableEventArgs Constructor
        /// </summary>
        /// <param name="parsed">a simple MessageParse</param>
        internal PutFetchableEventArgs(MessageParser parsed) {
            #if DEBUG
            FCP2.ArgsDebug(this, parsed);
            #endif
            
            this.global = bool.Parse(parsed["Global"]);
            this.identifier = parsed["Identifier"];
            this.uri = parsed["URI"];
            
            #if DEBUG
            parsed.PrintAccessCount();
            #endif
        }
    }
}