﻿/********************************************************************************
Copyright (C) MixERP Inc. (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.


MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/

using MixERP.Net.FrontEnd.Base;
using MixERP.Net.FrontEnd.Controls;
using MixERP.Net.i18n.Resources;
using System;

namespace MixERP.Net.Core.Modules.Finance.Setup
{
    public partial class CashFlowHeadings : MixERPUserControl
    {
        public override void OnControlLoad(object sender, EventArgs e)
        {
            using (Scrud scrud = new Scrud())
            {
                scrud.KeyColumn = "cash_flow_heading_id";
                scrud.TableSchema = "core";
                scrud.Table = "cash_flow_headings";
                scrud.ViewSchema = "core";
                scrud.View = "cash_flow_heading_scrud_view";
                scrud.Text = Titles.CashFlowHeadings;


                this.ScrudPlaceholder.Controls.Add(scrud);
            }
        }
    }
}