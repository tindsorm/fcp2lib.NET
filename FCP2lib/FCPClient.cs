﻿/*
 *  The FCP2.0 Library, complete access to freenets FCP 2.0 Interface
 * 
 *  Copyright (c) 2009-2010 Thomas Bruderer <apophis@apophis.ch>
 *  Copyright (c) 2009 Felipe Barriga Richards
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

using FCP2.Protocol;

namespace FCP2
{
    /// <summary>
    /// Highlevel API
    /// </summary>
    class FCPClient
    {
        private FCP2Protocol fcp;

        FCPClient(string clientName)
        {
            fcp = new FCP2Protocol(clientName);
        }

        public FCP2Upload UploadFile()
        {
            return new FCP2Upload(fcp);
        }
        
        public FCP2Download DownloadFile()
        {
            return new FCP2Download(fcp);
        }
    }
}
