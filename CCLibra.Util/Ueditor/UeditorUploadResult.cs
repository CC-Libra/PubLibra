using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCLibra.Util.Ueditor
{
    /// <summary>
    /// 版 本 CCLibra 框架
    /// Copyright (c) chuchao
    /// 创建人：褚超
    /// 日 期：2017.03.07
    /// 描 述：百度编辑器UE上传返回结果
    /// </summary>
    public class UeditorUploadResult
    {
        public UeditorUploadState State { get; set; }
        public string Url { get; set; }
        public string OriginFileName { get; set; }

        public string ErrorMessage { get; set; }
    }

    public enum UeditorUploadState
    {
        Success = 0,
        SizeLimitExceed = -1,
        TypeNotAllow = -2,
        FileAccessError = -3,
        NetworkError = -4,
        Unknown = 1,
    }
}
