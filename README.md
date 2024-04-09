# SelectedCellsGridViewTelerikBug

Example for issue opened in [Telerik forum](https://www.telerik.com/forums/radgridview-winforms-missing-selected-cells)

To reproduce the issue:
1. Click the first cell of a column
2. Scroll down and press Shift key and click the last cell of the column
3. Check that total rows label is 20.000 but selected cells label is less than 20.000
