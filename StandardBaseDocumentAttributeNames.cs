﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace UMP.Loodsman.Dtos
{
    public class StandardBaseDocumentAttributeNames : IBaseDocumentAttributeNames
    {
        private readonly IBaseAttributeNames baseAttributeNames;

        public StandardBaseDocumentAttributeNames(IBaseAttributeNames baseAttributeNames)
        {
            this.baseAttributeNames = baseAttributeNames;
        }

        public IEnumerator<string> GetEnumerator() =>
            baseAttributeNames.GetEnumerator(Author, AuthorDepartment, ReceiverDepartment, Title);

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public string Author => baseAttributeNames.Author;

        public string AuthorDepartment => baseAttributeNames.AuthorDepartment;

        public string ReceiverDepartment => baseAttributeNames.ReceiverDepartment;

        public string Title => baseAttributeNames.Title;
    }
}