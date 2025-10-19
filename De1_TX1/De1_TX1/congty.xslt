<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="congty">
		<html>
			<head>
				<style>
					h1{
					text-align: center;
					color: blue;
					font-size: 24px;
					}

					table{
					width: 100%;
					border-collapse: collapse;
					}
					th, td{
					border: 1px solid black;
					padding: 8px;
					text-align: left;
					}

					.phongban{
					width: 100%;
					display: flex;
					align-items: center;
					justify-content: center;
					gap: 50px;
					}

					.phongban p{
					margin-right: 20px;
					}
				</style>
			</head>
			<body>
				<h1>THÔNG TIN CÔNG TY</h1>
				<xsl:for-each select="phongban">
					<div class="phongban">
						<p>
							Tên phòng: <b>
								<xsl:value-of select="tenphong"/>
							</b>
						</p>

						<p>
							Điện thoại:
							<b>
								<xsl:value-of select="dienthoai"/>
							</b>
						</p>
					</div>

					<table>
						<tr>
							<th>
								Mã nhân viên
							</th>
							<th>
								Họ tên
							</th>
							<th>
								Trình độ
							</th>
							<th>
								Số năm công tác
							</th>
						</tr>
			
					<xsl:for-each select="nhanvien">
						<tr>
							<td>
								<xsl:value-of select="manv"/>
							</td>
							<td>
								<xsl:value-of select="hoten"/>
							</td>
							<td>
								<xsl:value-of select="trinhdo"/>
							</td>
							<td>
								<xsl:value-of select="sonamcongtac"/>
							</td>
						</tr>
					</xsl:for-each>

					</table>
								  
				</xsl:for-each>

				<h3>
					Tổng số nhân viên trong công ty:
					<xsl:value-of select="count(.//nhanvien)"/>
				</h3>
				

			</body>
		</html>
        <!--<xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>-->
    </xsl:template>
</xsl:stylesheet>
