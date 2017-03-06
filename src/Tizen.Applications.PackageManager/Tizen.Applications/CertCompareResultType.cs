/*
 * Copyright (c) 2017 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Tizen.Applications
{
    /// <summary>
    /// Enumeration for certificate compare result type.
    /// </summary>
    public enum CertCompareResultType
    {
        /// <summary>
        /// Certificates are matched.
        /// </summary>
        Match = Interop.PackageManager.CertCompareResultType.Match,
        /// <summary>
        /// Certificates are not matched.
        /// </summary>
        Mismatch = Interop.PackageManager.CertCompareResultType.Mismatch,
        /// <summary>
        /// First package doesn't have certificate.
        /// </summary>
        LhsNoCert = Interop.PackageManager.CertCompareResultType.LhsNoCert,
        /// <summary>
        /// Second package doesn't have certificate.
        /// </summary>
        RhsNoCert = Interop.PackageManager.CertCompareResultType.RhsNoCert,
        /// <summary>
        /// Certificates of both packages are not exist.
        /// </summary>
        BothNoCert = Interop.PackageManager.CertCompareResultType.BothNoCert
    }
}
