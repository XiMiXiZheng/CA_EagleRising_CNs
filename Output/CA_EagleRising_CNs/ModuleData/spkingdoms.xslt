<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>

	<xsl:template match="Kingdoms/Kingdom[@id='empire']/@name">
		<xsl:attribute name="name">{=0d9PUdGK}</xsl:attribute>
	</xsl:template>
	<xsl:template match="Kingdoms/Kingdom[@id='empire']/@short_name">
		<xsl:attribute name="short_name">{=0d9PUdGK}</xsl:attribute>
	</xsl:template>
	<xsl:template match="Kingdoms/Kingdom[@id='empire']/@title">
		<xsl:attribute name="title">{=0d9PUdGK}</xsl:attribute>
	</xsl:template>

	<xsl:template match="Kingdoms/Kingdom[@id='empire_w']/@name">
		<xsl:attribute name="name">{=Mk8VJ783}</xsl:attribute>
	</xsl:template>
	<xsl:template match="Kingdoms/Kingdom[@id='empire_w']/@short_name">
		<xsl:attribute name="short_name">{=Mk8VJ783}</xsl:attribute>
	</xsl:template>
	<xsl:template match="Kingdoms/Kingdom[@id='empire_w']/@title">
		<xsl:attribute name="title">{=Mk8VJ783}</xsl:attribute>
	</xsl:template>

	<xsl:template match="Kingdoms/Kingdom[@id='empire_s']/@name">
		<xsl:attribute name="name">{=ptkvhXv4}</xsl:attribute>
	</xsl:template>
	<xsl:template match="Kingdoms/Kingdom[@id='empire_s']/@short_name">
		<xsl:attribute name="short_name">{=ptkvhXv4}</xsl:attribute>
	</xsl:template>
	<xsl:template match="Kingdoms/Kingdom[@id='empire_s']/@title">
		<xsl:attribute name="title">{=ptkvhXv4}</xsl:attribute>
	</xsl:template>

	<xsl:template match="Kingdoms/Kingdom[@id='battania']/@name">
		<xsl:attribute name="name">{=Zok3yY7B}Battania</xsl:attribute>
	</xsl:template>
	<xsl:template match="Kingdoms/Kingdom[@id='battania']/@title">
		<xsl:attribute name="title">{=NpEy0Zd3}High Kingdom of the Battanians</xsl:attribute>
	</xsl:template>
</xsl:stylesheet>