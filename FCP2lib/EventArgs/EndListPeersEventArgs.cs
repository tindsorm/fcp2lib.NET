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
using System.IO;
using System.Collections.Generic;

namespace Freenet.FCP2 {
    
    public class EndListPeersEventArgs : EventArgs {
        
        /// <summary>
        /// EndListPeersEventArgs Constructor
        /// </summary>
        /// <param name="parsed">a simple MessageParse</param>
        public EndListPeersEventArgs(MessageParser parsed) {
            FCP2.ArgsDebug(this, parsed);
        }
    }
}