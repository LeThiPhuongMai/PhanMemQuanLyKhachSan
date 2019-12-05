<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="QL_KhachSan.DangKy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quản lý khách sạn</title>
    <link href="Style.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"/>
	<script src="https://kit.fontawesome.com/89a94d290c.js"></script>
</head>
<body>
    <div class="container">
        <nav class="navbar navbar-expand-lg border-bottom box-shadow-nav">
		    <a class="navbar-brand" href="#"><img style="height:60px" id="logo" src="images/logo.PNG" alt=""/></a>
		    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
			    <i class="fas fa-search"></i>
		    </button>
		    <div class="collapse navbar-collapse" id="navbarText">
			    <ul class="navbar-nav mr-auto ml-auto">
				    <li class="nav-item">
					    <a class="nav-link" href="TrangChu.aspx">Trang chủ<span class="sr-only">(current)</span></a>
				    </li>
				    <li class="nav-item dropdown">
						    <a class="nav-link dropdown-toggle" href="#" id="dropdown05" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Phòng</a>
						    <div class="dropdown-menu" aria-labelledby="dropdown05">
							    <a class="dropdown-item" href="#">Phòng đơn</a>
							    <a class="dropdown-item" href="#">Phòng đôi</a>
							    <a class="dropdown-item" href="#">Phòng ba</a>
                                 <a class="dropdown-item" href="#">Phòng Vip</a>
						    </div>
					    </li>
				    <li class="nav-item">
					    <a class="nav-link" href="#">Đặt phòng</a>
				    </li>
                    <li class="nav-item">
					    <a class="nav-link" href="#">Liên hệ</a>
				    </li>
                    <li class="nav-item">
					    <a class="nav-link" href="#">Giới thiệu</a>
				    </li>
			    </ul>
		    </div>
		    <span class="navbar-text">
				    <a href="DangKy.aspx" ><button class="btn btn-outline-success my-2 my-sm-0" type="submit" >Đăng ký</></a>
		    </span>
	    </nav>
    </div>
   <form>
      <div class="container">
		<div class="row m-auto">
			<div class="col-6 m-auto">
				<div class="form-group">
					<h3 style="color:blue; font-weight:bold">THÔNG TIN KHÁCH HÀNG</h3>
				</div>
				<div class="form-group" >
					<label for="exampleInputEmail1">Tên khách hàng</label>
					<input type="text" class="form-control" id="exampleInputEmail1" placeholder="Vui lòng nhập tên!"/>     
				</div>
				<div class="form-group">
					<label for="exampleInputPassword1">CMND</label>
					<input type="text" class="form-control" id="exampleInputPassword1" placeholder="Vui lòng nhập CMND"/>
				</div>
				<div class="form-group">
					<label>Số điện thoại</label>
					<input type="text" class="form-control" id="Text3" placeholder="Vui lòng nhập SDT"/>
				</div>
				<div class="form-group">
					<label>Địa chỉ</label>
					<input type="text" class="form-control" id="Text1" placeholder="Vui lòng nhập địa chỉ"/>
				</div>
				<div class="form-group">
					<label>Giới tính</label> &nbsp;&nbsp;&nbsp;&nbsp;
					<input name="gioitinh" type="radio" value="Nam" />Nam &nbsp;&nbsp;&nbsp;&nbsp;
					<input name="gioitinh" type="radio" value="Nữ" />Nữ
				</div>
				<button type="submit" class="btn btn-primary">Đăng nhập</button>
			</div>
		</div>
	</div>
    </form>

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
	<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</body>
</html>
