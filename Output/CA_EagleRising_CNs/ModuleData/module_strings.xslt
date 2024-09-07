<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:output omit-xml-declaration="yes"/>
    <xsl:template match="@*|node()">
        <xsl:copy>
            <xsl:apply-templates select="@*|node()"/>
        </xsl:copy>
    </xsl:template>
	
	<xsl:template match="string[@id='str_culture_description.battania']/@text">
		<xsl:attribute name="text">{=z0J5E53c}The Battanians still remember the olden days when the woods stretched across northern Calradia, and the Empire and its cities had yet to violate their sanctity. The fierce warriors remain loyal to their traditional ways. They paint their faces when going to battle and even their noblemen prefer to fight on foot while using great axes and two-handed swords with deadly efficiency.</xsl:attribute>
	</xsl:template>
	<xsl:template match="string[@id='str_culture_description.khuzait']/@text">
		<xsl:attribute name="text">{=3Ujo4ba7}The Khuzait confederation of steppe tribes used to live a nomadic life, but have recently settled in the eastern frontier of the Empire and are slowly transitioning into an agrarian society with permanent town centers. Despite this, they still retain many aspects of their nomadic life, including their affinity with horses. They are masters of mounted archery, shooting and then galloping out of reach.</xsl:attribute>
	</xsl:template>
	<xsl:template match="string[@id='str_culture_description.empire']/@text">
		<xsl:attribute name="text">{=91Kq0JWb}The Calradian Empire is in decline. Even before the suspicious death of the Emperor Arenicos, the once united realm was torn by political rivalries. Today, those factions are in open war. Yet Calradians endure. Their methodical study of defensive strategy, in which garrison cities slow down invading forces until mobile field armies can come to their rescue, helps hold their neighbors at bay.</xsl:attribute>
	</xsl:template>
	<xsl:template match="string[@id='str_adjective_for_faction.empire']/@text">
		<xsl:attribute name="text">{=nD1ZQ7He}northern imperial</xsl:attribute>
	</xsl:template>
	<xsl:template match="string[@id='str_adjective_for_faction.empire_w']/@text">
		<xsl:attribute name="text">{=Iov4Z5FB}western imperial</xsl:attribute>
	</xsl:template>
	<xsl:template match="string[@id='str_adjective_for_faction.empire_s']/@text">
		<xsl:attribute name="text">{=44zTqTuN}southern imperial</xsl:attribute>
	</xsl:template>
	<xsl:template match="string[@id='str_short_term_for_faction.empire']/@text">
		<xsl:attribute name="text">{=EgvYnJSx}Northern Empire</xsl:attribute>
	</xsl:template>
	<xsl:template match="string[@id='str_short_term_for_faction.empire_w']/@text">
		<xsl:attribute name="text">{=xCVoZ8yn}Western Empire</xsl:attribute>
	</xsl:template>
	<xsl:template match="string[@id='str_short_term_for_faction.empire_s']/@text">
		<xsl:attribute name="text">{=M25RQOuT}Southern Empire</xsl:attribute>
	</xsl:template>
	<xsl:template match="string[@id='str_adjective_for_culture.empire']/@text">
		<xsl:attribute name="text">{=gqyMrySN}imperial</xsl:attribute>
	</xsl:template>
	<xsl:template match="string[@id='str_neutral_term_for_culture.empire']/@text">
		<xsl:attribute name="text">{=gqyMrySN}imperial</xsl:attribute>
	</xsl:template>
	

</xsl:stylesheet>