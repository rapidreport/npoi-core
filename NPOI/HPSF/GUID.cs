﻿/* ====================================================================
   Licensed to the Apache Software Foundation (ASF) Under one or more
   contributor license agreements.  See the NOTICE file distributed with
   this work for Additional information regarding copyright ownership.
   The ASF licenses this file to You Under the Apache License, Version 2.0
   (the "License"); you may not use this file except in compliance with
   the License.  You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed Under the License is distributed on an "AS Is" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations Under the License.
==================================================================== */
using jp.co.systembase.NPOI.Util;

namespace jp.co.systembase.NPOI.HPSF
{
    public class GUID
    {
        public const int SIZE = 16;

        private int _data1;
        private short _data2;
        private short _data3;
        private long _data4;
        public GUID(byte[] data, int offset)
        {
            _data1 = LittleEndian.GetInt(data, offset + 0);
            _data2 = LittleEndian.GetShort(data, offset + 4);
            _data3 = LittleEndian.GetShort(data, offset + 6);
            _data4 = LittleEndian.GetLong(data, offset + 8);
        }
    }
}