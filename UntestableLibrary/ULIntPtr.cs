﻿/* 
 * File: ULIntPtr.cs
 * 
 * Author: Akira Sugiura (urasandesu@gmail.com)
 * 
 * 
 * Copyright (c) 2014 Akira Sugiura
 *  
 *  This software is MIT License.
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy
 *  of this software and associated documentation files (the "Software"), to deal
 *  in the Software without restriction, including without limitation the rights
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *  copies of the Software, and to permit persons to whom the Software is
 *  furnished to do so, subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in
 *  all copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 *  THE SOFTWARE.
 */



namespace UntestableLibrary
{
    public struct ULIntPtr
    {
        unsafe void* m_p;

        public unsafe ULIntPtr(int value)
        {
            this.m_p = (void*)value;
        }

        public unsafe ULIntPtr(long value)
        {
            this.m_p = (void*)checked((int)value);
        }

        public unsafe bool IsNull()
        {
            return this.m_p == null;
        }

        public unsafe int ToInt32()
        {
            return (int)this.m_p;
        }

        public unsafe long ToInt64()
        {
            return (long)this.m_p;
        }

        public static unsafe int Size
        {
            get { return sizeof(void*); }
        }
    }
}
