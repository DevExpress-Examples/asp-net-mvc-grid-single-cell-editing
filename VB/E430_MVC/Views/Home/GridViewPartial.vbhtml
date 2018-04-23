@Html.DevExpress().GridView(Sub(settings)
	settings.Name = "GridView"
	settings.KeyFieldName = "Id"
	settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridViewPartial"}
	settings.Width = Unit.Percentage(100)
	settings.Columns.Add(Sub(column)
		column.FieldName = "C1"
		column.Width = Unit.Percentage(20)
	End Sub)
	settings.Columns.Add(Sub(column)
		column.FieldName = "C2"
		column.ColumnType = MVCxGridViewColumnType.SpinEdit
		column.Width = Unit.Percentage(20)
	End Sub)
	settings.Columns.Add(Sub(column)
		column.FieldName = "C3"
		column.ColumnType = MVCxGridViewColumnType.CheckBox
		column.Width = Unit.Percentage(20)
	End Sub)
	settings.Columns.Add(Sub(column)
		column.FieldName = "C4"
		column.ColumnType = MVCxGridViewColumnType.CheckBox
		column.Width = Unit.Percentage(20)
	End Sub)
	settings.Columns.Add(Sub(column)
		column.FieldName = "C5"
		column.ColumnType = MVCxGridViewColumnType.DateEdit
		column.Width = Unit.Percentage(20)
	End Sub)
	settings.CellEditorInitialize = Sub(s, e)
		Dim editor As ASPxEdit = CType(e.Editor, ASPxEdit)
		editor.ValidationSettings.Display = Display.Dynamic
	End Sub
	settings.ClientSideEvents.BatchEditEndEditing = "onBatchEditEndEditing"
	settings.Styles.BatchEditModifiedCell.BackColor = System.Drawing.Color.White
	settings.SettingsEditing.Mode = GridViewEditingMode.Batch
	settings.SettingsEditing.BatchEditSettings.ShowConfirmOnLosingChanges = False
	settings.SettingsEditing.BatchEditSettings.StartEditAction = GridViewBatchStartEditAction.Click
	settings.Settings.ShowStatusBar = GridViewStatusBarMode.Hidden
End Sub).Bind(Model).GetHtml()