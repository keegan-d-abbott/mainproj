<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim Customer_IDLabel As System.Windows.Forms.Label
        Dim Loyalty_PointsLabel As System.Windows.Forms.Label
        Dim Cust_FnameLabel As System.Windows.Forms.Label
        Dim Cust_LnameLabel As System.Windows.Forms.Label
        Dim Cust_SuburbLabel As System.Windows.Forms.Label
        Dim Cust_Post_AddressLabel As System.Windows.Forms.Label
        Dim Cust_Post_CodeLabel As System.Windows.Forms.Label
        Dim Cust_GenderLabel As System.Windows.Forms.Label
        Dim Cust_PhoneNoLabel As System.Windows.Forms.Label
        Dim Cust_EmailLabel As System.Windows.Forms.Label
        Dim Cust_DOBLabel As System.Windows.Forms.Label
        Dim Cust_isActiveLabel As System.Windows.Forms.Label
        Dim User_typeLabel As System.Windows.Forms.Label
        Dim Cust_PasswordLabel As System.Windows.Forms.Label
        Me.Group29DataSet = New WindowsApplication1.group29DataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New WindowsApplication1.group29DataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.group29DataSetTableAdapters.TableAdapterManager()
        Me.CustomerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Customer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Loyalty_PointsTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_FnameTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_LnameTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_SuburbTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_Post_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_Post_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_PhoneNoTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_DOBDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Cust_isActiveTextBox = New System.Windows.Forms.TextBox()
        Me.User_typeTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_PasswordTextBox = New System.Windows.Forms.TextBox()
        Customer_IDLabel = New System.Windows.Forms.Label()
        Loyalty_PointsLabel = New System.Windows.Forms.Label()
        Cust_FnameLabel = New System.Windows.Forms.Label()
        Cust_LnameLabel = New System.Windows.Forms.Label()
        Cust_SuburbLabel = New System.Windows.Forms.Label()
        Cust_Post_AddressLabel = New System.Windows.Forms.Label()
        Cust_Post_CodeLabel = New System.Windows.Forms.Label()
        Cust_GenderLabel = New System.Windows.Forms.Label()
        Cust_PhoneNoLabel = New System.Windows.Forms.Label()
        Cust_EmailLabel = New System.Windows.Forms.Label()
        Cust_DOBLabel = New System.Windows.Forms.Label()
        Cust_isActiveLabel = New System.Windows.Forms.Label()
        User_typeLabel = New System.Windows.Forms.Label()
        Cust_PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.Group29DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Group29DataSet
        '
        Me.Group29DataSet.DataSetName = "group29DataSet"
        Me.Group29DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Group29DataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.IngredientTableAdapter = Nothing
        Me.TableAdapterManager.MenuItemTableAdapter = Nothing
        Me.TableAdapterManager.OrderLineTableAdapter = Nothing
        Me.TableAdapterManager.OrderPaymentTableAdapter = Nothing
        Me.TableAdapterManager.OrderTBLTableAdapter = Nothing
        Me.TableAdapterManager.RecipeTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableTableAdapter = Nothing
        Me.TableAdapterManager.TableTBLTableAdapter = Nothing
        Me.TableAdapterManager.TimeSlotTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.group29DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WaiterTableAdapter = Nothing
        '
        'CustomerBindingNavigator
        '
        Me.CustomerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerBindingNavigator.BindingSource = Me.CustomerBindingSource
        Me.CustomerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerBindingNavigatorSaveItem})
        Me.CustomerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerBindingNavigator.Name = "CustomerBindingNavigator"
        Me.CustomerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerBindingNavigator.Size = New System.Drawing.Size(588, 25)
        Me.CustomerBindingNavigator.TabIndex = 0
        Me.CustomerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'CustomerBindingNavigatorSaveItem
        '
        Me.CustomerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerBindingNavigatorSaveItem.Name = "CustomerBindingNavigatorSaveItem"
        Me.CustomerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CustomerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Location = New System.Drawing.Point(93, 57)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(68, 13)
        Customer_IDLabel.TabIndex = 1
        Customer_IDLabel.Text = "Customer ID:"
        '
        'Customer_IDTextBox
        '
        Me.Customer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Customer_ID", True))
        Me.Customer_IDTextBox.Location = New System.Drawing.Point(195, 54)
        Me.Customer_IDTextBox.Name = "Customer_IDTextBox"
        Me.Customer_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Customer_IDTextBox.TabIndex = 2
        '
        'Loyalty_PointsLabel
        '
        Loyalty_PointsLabel.AutoSize = True
        Loyalty_PointsLabel.Location = New System.Drawing.Point(93, 83)
        Loyalty_PointsLabel.Name = "Loyalty_PointsLabel"
        Loyalty_PointsLabel.Size = New System.Drawing.Size(75, 13)
        Loyalty_PointsLabel.TabIndex = 3
        Loyalty_PointsLabel.Text = "Loyalty Points:"
        '
        'Loyalty_PointsTextBox
        '
        Me.Loyalty_PointsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Loyalty_Points", True))
        Me.Loyalty_PointsTextBox.Location = New System.Drawing.Point(195, 80)
        Me.Loyalty_PointsTextBox.Name = "Loyalty_PointsTextBox"
        Me.Loyalty_PointsTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Loyalty_PointsTextBox.TabIndex = 4
        '
        'Cust_FnameLabel
        '
        Cust_FnameLabel.AutoSize = True
        Cust_FnameLabel.Location = New System.Drawing.Point(93, 109)
        Cust_FnameLabel.Name = "Cust_FnameLabel"
        Cust_FnameLabel.Size = New System.Drawing.Size(66, 13)
        Cust_FnameLabel.TabIndex = 5
        Cust_FnameLabel.Text = "Cust Fname:"
        '
        'Cust_FnameTextBox
        '
        Me.Cust_FnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Fname", True))
        Me.Cust_FnameTextBox.Location = New System.Drawing.Point(195, 106)
        Me.Cust_FnameTextBox.Name = "Cust_FnameTextBox"
        Me.Cust_FnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cust_FnameTextBox.TabIndex = 6
        '
        'Cust_LnameLabel
        '
        Cust_LnameLabel.AutoSize = True
        Cust_LnameLabel.Location = New System.Drawing.Point(93, 135)
        Cust_LnameLabel.Name = "Cust_LnameLabel"
        Cust_LnameLabel.Size = New System.Drawing.Size(66, 13)
        Cust_LnameLabel.TabIndex = 7
        Cust_LnameLabel.Text = "Cust Lname:"
        '
        'Cust_LnameTextBox
        '
        Me.Cust_LnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Lname", True))
        Me.Cust_LnameTextBox.Location = New System.Drawing.Point(195, 132)
        Me.Cust_LnameTextBox.Name = "Cust_LnameTextBox"
        Me.Cust_LnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cust_LnameTextBox.TabIndex = 8
        '
        'Cust_SuburbLabel
        '
        Cust_SuburbLabel.AutoSize = True
        Cust_SuburbLabel.Location = New System.Drawing.Point(93, 161)
        Cust_SuburbLabel.Name = "Cust_SuburbLabel"
        Cust_SuburbLabel.Size = New System.Drawing.Size(68, 13)
        Cust_SuburbLabel.TabIndex = 9
        Cust_SuburbLabel.Text = "Cust Suburb:"
        '
        'Cust_SuburbTextBox
        '
        Me.Cust_SuburbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Suburb", True))
        Me.Cust_SuburbTextBox.Location = New System.Drawing.Point(195, 158)
        Me.Cust_SuburbTextBox.Name = "Cust_SuburbTextBox"
        Me.Cust_SuburbTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cust_SuburbTextBox.TabIndex = 10
        '
        'Cust_Post_AddressLabel
        '
        Cust_Post_AddressLabel.AutoSize = True
        Cust_Post_AddressLabel.Location = New System.Drawing.Point(93, 187)
        Cust_Post_AddressLabel.Name = "Cust_Post_AddressLabel"
        Cust_Post_AddressLabel.Size = New System.Drawing.Size(96, 13)
        Cust_Post_AddressLabel.TabIndex = 11
        Cust_Post_AddressLabel.Text = "Cust Post Address:"
        '
        'Cust_Post_AddressTextBox
        '
        Me.Cust_Post_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Post_Address", True))
        Me.Cust_Post_AddressTextBox.Location = New System.Drawing.Point(195, 184)
        Me.Cust_Post_AddressTextBox.Name = "Cust_Post_AddressTextBox"
        Me.Cust_Post_AddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cust_Post_AddressTextBox.TabIndex = 12
        '
        'Cust_Post_CodeLabel
        '
        Cust_Post_CodeLabel.AutoSize = True
        Cust_Post_CodeLabel.Location = New System.Drawing.Point(93, 213)
        Cust_Post_CodeLabel.Name = "Cust_Post_CodeLabel"
        Cust_Post_CodeLabel.Size = New System.Drawing.Size(83, 13)
        Cust_Post_CodeLabel.TabIndex = 13
        Cust_Post_CodeLabel.Text = "Cust Post Code:"
        '
        'Cust_Post_CodeTextBox
        '
        Me.Cust_Post_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Post_Code", True))
        Me.Cust_Post_CodeTextBox.Location = New System.Drawing.Point(195, 210)
        Me.Cust_Post_CodeTextBox.Name = "Cust_Post_CodeTextBox"
        Me.Cust_Post_CodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cust_Post_CodeTextBox.TabIndex = 14
        '
        'Cust_GenderLabel
        '
        Cust_GenderLabel.AutoSize = True
        Cust_GenderLabel.Location = New System.Drawing.Point(93, 239)
        Cust_GenderLabel.Name = "Cust_GenderLabel"
        Cust_GenderLabel.Size = New System.Drawing.Size(69, 13)
        Cust_GenderLabel.TabIndex = 15
        Cust_GenderLabel.Text = "Cust Gender:"
        '
        'Cust_GenderTextBox
        '
        Me.Cust_GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Gender", True))
        Me.Cust_GenderTextBox.Location = New System.Drawing.Point(195, 236)
        Me.Cust_GenderTextBox.Name = "Cust_GenderTextBox"
        Me.Cust_GenderTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cust_GenderTextBox.TabIndex = 16
        '
        'Cust_PhoneNoLabel
        '
        Cust_PhoneNoLabel.AutoSize = True
        Cust_PhoneNoLabel.Location = New System.Drawing.Point(93, 265)
        Cust_PhoneNoLabel.Name = "Cust_PhoneNoLabel"
        Cust_PhoneNoLabel.Size = New System.Drawing.Size(82, 13)
        Cust_PhoneNoLabel.TabIndex = 17
        Cust_PhoneNoLabel.Text = "Cust Phone No:"
        '
        'Cust_PhoneNoTextBox
        '
        Me.Cust_PhoneNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_PhoneNo", True))
        Me.Cust_PhoneNoTextBox.Location = New System.Drawing.Point(195, 262)
        Me.Cust_PhoneNoTextBox.Name = "Cust_PhoneNoTextBox"
        Me.Cust_PhoneNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cust_PhoneNoTextBox.TabIndex = 18
        '
        'Cust_EmailLabel
        '
        Cust_EmailLabel.AutoSize = True
        Cust_EmailLabel.Location = New System.Drawing.Point(93, 291)
        Cust_EmailLabel.Name = "Cust_EmailLabel"
        Cust_EmailLabel.Size = New System.Drawing.Size(59, 13)
        Cust_EmailLabel.TabIndex = 19
        Cust_EmailLabel.Text = "Cust Email:"
        '
        'Cust_EmailTextBox
        '
        Me.Cust_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Email", True))
        Me.Cust_EmailTextBox.Location = New System.Drawing.Point(195, 288)
        Me.Cust_EmailTextBox.Name = "Cust_EmailTextBox"
        Me.Cust_EmailTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cust_EmailTextBox.TabIndex = 20
        '
        'Cust_DOBLabel
        '
        Cust_DOBLabel.AutoSize = True
        Cust_DOBLabel.Location = New System.Drawing.Point(93, 318)
        Cust_DOBLabel.Name = "Cust_DOBLabel"
        Cust_DOBLabel.Size = New System.Drawing.Size(57, 13)
        Cust_DOBLabel.TabIndex = 21
        Cust_DOBLabel.Text = "Cust DOB:"
        '
        'Cust_DOBDateTimePicker
        '
        Me.Cust_DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CustomerBindingSource, "Cust_DOB", True))
        Me.Cust_DOBDateTimePicker.Location = New System.Drawing.Point(195, 314)
        Me.Cust_DOBDateTimePicker.Name = "Cust_DOBDateTimePicker"
        Me.Cust_DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Cust_DOBDateTimePicker.TabIndex = 22
        '
        'Cust_isActiveLabel
        '
        Cust_isActiveLabel.AutoSize = True
        Cust_isActiveLabel.Location = New System.Drawing.Point(93, 343)
        Cust_isActiveLabel.Name = "Cust_isActiveLabel"
        Cust_isActiveLabel.Size = New System.Drawing.Size(74, 13)
        Cust_isActiveLabel.TabIndex = 23
        Cust_isActiveLabel.Text = "Cust is Active:"
        '
        'Cust_isActiveTextBox
        '
        Me.Cust_isActiveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_isActive", True))
        Me.Cust_isActiveTextBox.Location = New System.Drawing.Point(195, 340)
        Me.Cust_isActiveTextBox.Name = "Cust_isActiveTextBox"
        Me.Cust_isActiveTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cust_isActiveTextBox.TabIndex = 24
        '
        'User_typeLabel
        '
        User_typeLabel.AutoSize = True
        User_typeLabel.Location = New System.Drawing.Point(93, 369)
        User_typeLabel.Name = "User_typeLabel"
        User_typeLabel.Size = New System.Drawing.Size(55, 13)
        User_typeLabel.TabIndex = 25
        User_typeLabel.Text = "User type:"
        '
        'User_typeTextBox
        '
        Me.User_typeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "User_type", True))
        Me.User_typeTextBox.Location = New System.Drawing.Point(195, 366)
        Me.User_typeTextBox.Name = "User_typeTextBox"
        Me.User_typeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.User_typeTextBox.TabIndex = 26
        '
        'Cust_PasswordLabel
        '
        Cust_PasswordLabel.AutoSize = True
        Cust_PasswordLabel.Location = New System.Drawing.Point(93, 395)
        Cust_PasswordLabel.Name = "Cust_PasswordLabel"
        Cust_PasswordLabel.Size = New System.Drawing.Size(80, 13)
        Cust_PasswordLabel.TabIndex = 27
        Cust_PasswordLabel.Text = "Cust Password:"
        '
        'Cust_PasswordTextBox
        '
        Me.Cust_PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_Password", True))
        Me.Cust_PasswordTextBox.Location = New System.Drawing.Point(195, 392)
        Me.Cust_PasswordTextBox.Name = "Cust_PasswordTextBox"
        Me.Cust_PasswordTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Cust_PasswordTextBox.TabIndex = 28
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 432)
        Me.Controls.Add(Customer_IDLabel)
        Me.Controls.Add(Me.Customer_IDTextBox)
        Me.Controls.Add(Loyalty_PointsLabel)
        Me.Controls.Add(Me.Loyalty_PointsTextBox)
        Me.Controls.Add(Cust_FnameLabel)
        Me.Controls.Add(Me.Cust_FnameTextBox)
        Me.Controls.Add(Cust_LnameLabel)
        Me.Controls.Add(Me.Cust_LnameTextBox)
        Me.Controls.Add(Cust_SuburbLabel)
        Me.Controls.Add(Me.Cust_SuburbTextBox)
        Me.Controls.Add(Cust_Post_AddressLabel)
        Me.Controls.Add(Me.Cust_Post_AddressTextBox)
        Me.Controls.Add(Cust_Post_CodeLabel)
        Me.Controls.Add(Me.Cust_Post_CodeTextBox)
        Me.Controls.Add(Cust_GenderLabel)
        Me.Controls.Add(Me.Cust_GenderTextBox)
        Me.Controls.Add(Cust_PhoneNoLabel)
        Me.Controls.Add(Me.Cust_PhoneNoTextBox)
        Me.Controls.Add(Cust_EmailLabel)
        Me.Controls.Add(Me.Cust_EmailTextBox)
        Me.Controls.Add(Cust_DOBLabel)
        Me.Controls.Add(Me.Cust_DOBDateTimePicker)
        Me.Controls.Add(Cust_isActiveLabel)
        Me.Controls.Add(Me.Cust_isActiveTextBox)
        Me.Controls.Add(User_typeLabel)
        Me.Controls.Add(Me.User_typeTextBox)
        Me.Controls.Add(Cust_PasswordLabel)
        Me.Controls.Add(Me.Cust_PasswordTextBox)
        Me.Controls.Add(Me.CustomerBindingNavigator)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Group29DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerBindingNavigator.ResumeLayout(False)
        Me.CustomerBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Group29DataSet As group29DataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As group29DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As group29DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CustomerBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Customer_IDTextBox As TextBox
    Friend WithEvents Loyalty_PointsTextBox As TextBox
    Friend WithEvents Cust_FnameTextBox As TextBox
    Friend WithEvents Cust_LnameTextBox As TextBox
    Friend WithEvents Cust_SuburbTextBox As TextBox
    Friend WithEvents Cust_Post_AddressTextBox As TextBox
    Friend WithEvents Cust_Post_CodeTextBox As TextBox
    Friend WithEvents Cust_GenderTextBox As TextBox
    Friend WithEvents Cust_PhoneNoTextBox As TextBox
    Friend WithEvents Cust_EmailTextBox As TextBox
    Friend WithEvents Cust_DOBDateTimePicker As DateTimePicker
    Friend WithEvents Cust_isActiveTextBox As TextBox
    Friend WithEvents User_typeTextBox As TextBox
    Friend WithEvents Cust_PasswordTextBox As TextBox
End Class
