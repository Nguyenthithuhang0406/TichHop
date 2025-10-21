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
					width: 100%;
					border-collapse: collapse;
					background-color:green;
					}

					th,td{
					border: 1px solid black;
					padding: 8px;
					text-align: center;
					}

					.hoten{
					color:red;
					font-style:italic;
					}
				</style>
			</head>
			<body>
				<h1>BANG CHI TRA VIEN PHI</h1>
				<p>
					<b>Ten benh vien: </b>
					<xsl:value-of select="@tenbv"/>
				</p>
				<xsl:apply-templates select="khoa"/>
			</body>
		</html>
    </xsl:template>
	<xsl:template match="khoa">
		<p>
			<b>Ten khoa kham:</b>
			<xsl:value-of select="tenkhoa"/>
		</p>
		<table>
			<tr>
				<th>STT</th>
				<th class="hoten">Ho ten</th>
				<th>So nay nam vien</th>
				<th>Vien phi</th>
			</tr>

			<xsl:apply-templates select="benhnhan"/>
		</table>
	</xsl:template>

	<xsl:template match="benhnhan">
		<xsl:variable name="songay" select="number(@songay)"/>
		<xsl:variable name="vienphi">
			<xsl:choose>
				<xsl:when test="$songay &lt;= 10">
					<xsl:value-of select="$songay * 100000"/>
				</xsl:when>
				<xsl:when test="$songay &lt;= 20">
					<xsl:value-of select="10 * 100000 + ($songay - 10) * 120000"/>
				</xsl:when>
				<xsl:otherwise>
					<xsl:value-of select="10 * 100000 + 10 * 120000 + ($songay - 20) * 200000"/>
				</xsl:otherwise>
			</xsl:choose>
		</xsl:variable>
		<tr>
			<td>
				<xsl:value-of select="position()"/>
			</td>
			<td class="hoten">
				<xsl:value-of select="hoten"/>
			</td>
			<td>
				<xsl:value-of select="@songay"/>
			</td>
			<td>
				<xsl:value-of select="$vienphi"/>
			</td>
		</tr>
	</xsl:template>
</xsl:stylesheet>
