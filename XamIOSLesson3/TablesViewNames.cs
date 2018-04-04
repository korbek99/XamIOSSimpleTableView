using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace XamIOSLesson3
{
    public class TablesViewNames : UITableViewSource
    {
        private List<string> names;

        public TablesViewNames(List<string> names)
        {
            this.names = names;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "");
            //cell.TextLabel.text = @"some Text";
            cell.TextLabel.Text = names[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
           return names.Count;
        }
    }
}
