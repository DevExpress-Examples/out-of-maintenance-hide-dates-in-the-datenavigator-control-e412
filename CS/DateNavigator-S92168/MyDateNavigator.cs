using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraScheduler;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Controls;

namespace WindowsApplication22 {
    public class CustomDateNavigator : DateNavigator {
        class MyDateEditInfoArgs : DateEditInfoArgs {
            public MyDateEditInfoArgs(DateEditCalendarBase calendar)
                : base(calendar) {
            }
            protected override void CalcDayNumberCells() {
                base.CalcDayNumberCells();
                RemoveInactiveDays();
            }
            protected void RemoveInactiveDays() {
                int count = DayCells.Count;
                for (int i = count - 1; i >= 0; i--)
                    if (!DayCells[i].IsActive)
                        DayCells.RemoveAt(i);
            }
        }
        protected override DateEditInfoArgs CreateInfoArgs() {
            return new MyDateEditInfoArgs(this);
        }
    }
}
