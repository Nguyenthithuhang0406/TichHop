<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="DS">
		<html>
			<head>
				<style>
					table{
					border-collapse: collapse;
					width: 100%;
					}
					th, td {
					border: 1px solid black;
					padding: 8px;
					text-align: left;
					}
					
				</style>
			</head>
			<body>
				<h1>BANG LUONG THANG</h1>
				<div>
					<xsl:for-each select="congty">
						<p>
							<b>Ten cong ty: </b>
							<xsl:value-of select="@TenCT"/>
						</p>

						<xsl:for-each select="donvi">
							<p>
								<b>Ten phong: </b>
								<xsl:value-of select="tendv"/>
							</p>

							<table>
								<tr>
									<th>STT</th>
									<th>Ho ten</th>
									<th>Ngay sinh</th>
									<th>Ngay cong</th>
									<th>Luong</th>
								</tr>

								<xsl:for-each select="nhanvien">
									<xsl:variable name="ngaycong" select="ngaycong" />
									
									<xsl:variable name="Luong">
										
									<xsl:choose>
										
										<xsl:when test="$ngaycong &lt;= 20">
											<xsl:value-of select="$ngaycong * 150000"/>
										</xsl:when>
										
										<xsl:when test="$ngaycong &lt;= 25">
											<xsl:value-of select="20 * 150000 + ($ngaycong - 20) * 200000"/>
										</xsl:when>
										
										<xsl:otherwise>
											<xsl:value-of select="20 * 150000 + 5 * 200000 + ($ngaycong - 25) * 250000"/>
										</xsl:otherwise>
										
									</xsl:choose>
									</xsl:variable>
									<tr>
										<td>
											<xsl:value-of select="position()"/>
										</td>
										<td>
											<xsl:value-of select="hoten"/>
										</td>
										<td>
											<xsl:value-of select="ngaysinh"/>
										</td>
										<td>
											<xsl:value-of select="ngaycong"/>
										</td>
										<td>
											<xsl:value-of select="$Luong"/>
										</td>
									</tr>
								</xsl:for-each>
							</table>
						</xsl:for-each>
					</xsl:for-each>
				</div>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
