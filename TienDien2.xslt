<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
	<xsl:output method="html" indent="yes"/>

	<xsl:template match="/">
		<html>
			<head>
				<title>Tính tiền điện</title>
				<style>
					body { font-family: Arial; margin: 30px; }
					table { border-collapse: collapse; width: 400px; }
					td, th { border: 1px solid #555; padding: 6px; text-align: center; }
					th { background-color: #f0f0f0; }
				</style>
			</head>
			<body>
				<h2>tính tiền điện hàng tháng</h2>
				<p>
					<b>Họ và tên: </b>
					<xsl:value-of select="/tiendien/hoten"/>
				</p>
				<p>
					<b>Chỉ số đầu  tháng: </b>
					<xsl:value-of select="/tiendien/chisodau"/>
				</p>
				<p>
					<b>Chỉ số cuối tháng: </b>
					<xsl:value-of select="/tiendien/chisocuoi"/>
				</p>

				<xsl:variable name="chisodau" select="/tiendien/chisodau"/>
				<xsl:variable name="chisocuoi" select="/tiendien/chisocuoi"/>
				<xsl:variable name="sodien" select="$chisocuoi - $chisodau"/>

				<h3>
					<b>
						Tổng số điện tiêu thụ: <xsl:value-of select="$sodien"/>
					</b>
				</h3>

				<!--tinh tien dien theo bac-->
				<xsl:variable name="tien">
					<xsl:if test="$sodien &lt;= 100">
						<xsl:value-of select="$sodien * 3000"/>
					</xsl:if>
					<xsl:if test="$sodien &gt; 100 and $sodien &lt;= 150">
						<xsl:value-of select="100 * 3000 + ($sodien - 100) * 4000"/>
					</xsl:if>
					<xsl:if test="$sodien &gt; 150 and $sodien &lt;= 200">
						<xsl:value-of select="100 * 3000 + 50 * 4000 + ($sodien - 150) * 4500"/>
					</xsl:if>
					<xsl:if test="$sodien &gt; 100">
						<xsl:value-of select="100 * 3000 + 50 * 4000 + 50 * 4500 + ($sodien - 200) * 5000"/>
					</xsl:if>
				</xsl:variable>

				<table>
					<tr>
						<th>Bậc</th>
						<th>Gía (đ/kWh)</th>
						<th>Sản lượng</th>
						<th>Thành tiền (đ)</th>
					</tr>

					<!--bac 1-->
					<tr>
						<td>0 - 100</td>
						<td>3000</td>
						<td>
							<xsl:if test="$sodien &lt;= 100">
								<xsl:value-of select="$sodien"/>
							</xsl:if>
							<xsl:if test="$sodien &gt; 100 ">
								100
							</xsl:if>
						</td>
						<td>
							<xsl:if test="$sodien &lt;= 100">
								<xsl:value-of select="$sodien * 3000"/>
							</xsl:if>
							<xsl:if test="$sodien &gt; 100 ">
								300000
							</xsl:if>
						</td>
					</tr>

					<!--bac 2-->
					<tr>
						<td>101 - 150</td>
						<td>4000</td>
						<td>
							<xsl:if test="$sodien &gt; 100 and $sodien &lt;= 150">
								<xsl:value-of select="$sodien - 100"/>
							</xsl:if>
							<xsl:if test="$sodien &gt; 150 ">
								50
							</xsl:if>
						</td>
						<td>
							<xsl:if test="$sodien &gt; 100 and $sodien &lt;= 150">
								<xsl:value-of select="($sodien - 100) * 4000"/>
							</xsl:if>
							<xsl:if test="$sodien &gt; 150 ">
								200000
							</xsl:if>
						</td>
					</tr>

					<!--bac 3-->
					<tr>
						<td>151 - 200</td>
						<td>4500</td>
						<td>
							<xsl:if test="$sodien &gt; 150 and $sodien &lt;= 200">
								<xsl:value-of select="$sodien - 150"/>
							</xsl:if>
							<xsl:if test="$sodien &gt; 200 ">
								50
							</xsl:if>
						</td>
						<td>
							<xsl:if test="$sodien &gt; 150 and $sodien &lt;= 200">
								<xsl:value-of select="($sodien - 150) * 4500"/>
							</xsl:if>
							<xsl:if test="$sodien &gt; 200 ">
								225000
							</xsl:if>
						</td>
					</tr>

					<!--bac 4-->
					<tr>
						<td>>200</td>
						<td>5000</td>
						<td>
							<xsl:if test="$sodien &lt;= 200">0</xsl:if>
							<xsl:if test="$sodien &gt; 200">
								<xsl:value-of select="$sodien - 200"/>
							</xsl:if>
						</td>
						<td>
							<xsl:if test="$sodien &lt;= 200">0</xsl:if>
							<xsl:if test="$sodien &gt; 200">
								<xsl:value-of select="($sodien - 200) * 5000"/>
							</xsl:if>
						</td>
					</tr>

					<tr>
						<th colspan="3">TỔNG TIỀN PHẢI TRẢ</th>
						<th>
							<xsl:value-of select="$tien"/> đ
						</th>
					</tr>


				</table>
			</body>
		</html>
	</xsl:template>

	<xsl:template match="@* | node()">
		<xsl:copy>
			<xsl:apply-templates select="@* | node()"/>
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>
