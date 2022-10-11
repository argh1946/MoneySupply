﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.FileAttachment
{
    public interface IFileAttachmentRepository : IAsyncGenericRepository<Entities.FileAttachment>
    {
    }
}
