* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
          Lattice3D Studio (CAD) Corel Edition Ver. 2.0 Installation Guide

                                    Developer: Lattice Technology Co.,Ltd.
                                        http://www.lattice3d.com/
                                        mailto:info@lattice3d.com

* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *

* INTRODUCTION

  Thank you for using Lattice3D Studio (CAD) Corel Edition (collectively referred to
  as "Lattice3D Studio Corel Edition").

  Lattice3D Studio Corel Edition reads, edits and writes XVL files, performing
  the following functions:

      - Viewing
      - Visibility control
      - Group editing
      - Material (color) and texture editing
      - Camera and light editing
      - Note creation and editing
      - Body allocation, copying, and deleting
      - Cross-sectioning
      - Interference checking
      - Measurement of distance/angle between shape elements
      - Surface area and volume calculation
      - Measurement and dimensioning

  XVL files edited in Lattice3D Studio Corel Edition are used in Lattice3D Player 
  (including Lattice3D Player Pro) and other products from
  Lattice Technology Co.,Ltd.

  This file contains important information on installation, release notes 
  and known issues.  Please be sure to read it prior to usage.


* SYSTEM REQUIREMENTS

  Lattice3D Studio Corel Edition operates in the environments listed below.

        OS:       Windows 7
                  Windows 7 x64
                  Windows 8
                  Windows 8 x64
                  Windows 8.1
                  Windows 8.1 x64
        CPU:      300MHz Intel or AMD CPU
                  (1 GHz or higher Intel or AMD CPU recommended)
        Memory:   256 MB or higher
                  (1 GB recommended)
        HDD:      400 MB or more of free space

  Lattice3D Studio Corel Edition 64-bit Edition operates in the environments listed below.

 	OS:       Windows 7 x64
                  Windows 8 x64 editions
                  Windows 8.1 x64 editions
        CPU:      Intel 64-enabled Intel or AMD64-enabled AMD CPU
        Memory:   256 MB
                  (1GB or higher recommended)
        HDD:      400 MB or more of free space

  - For information about supported graphics cards, please contact the
    distributor of this product.

    Note that Adobe LiveCycle Rights Management ES encrypted files cannot be
    used in Lattice3D Studio 64-bit Edition.

  - Japanese editions of Lattice3D products will run only on Japanese 
    versions of Windows, and German editions will run only on German versions
    of Windows.  For versions of Windows in other languages, use 
    English-version Lattice3D products. 

  - On 64bit-edition Windows, Lattice3D Studio runs as a 32-bit application 
    with the WOW64 subsystem.  To operate Lattice3D Studio in these 
    environments as a 64-bit program, use Lattice3D Studio 64-bit Edition.
    Note that Lattice3D Studio is not applied to Windows Vista 64-bit 
    Edition.

  - Internet Explorer 6.0 or later is needed to open public-key-encrypted 
    Lattice3D files.


* CAUTIONS

  - Users should be aware of the points outlined below when older versions
    are uninstalled and a new version is installed.

    1. Association may be deleted when older versions are uninstalled.

       When old versions of Lattice3D Player or Lattice3D Studio (Composer, 
       Director) are uninstalled, XVL file associations may be deleted (i.e. 
       Lattice3D Player or Lattice3D Studio may not start when an XVL file is
       double-clicked).  In such cases, uninstall Lattice3D Player or 
       Lattice3D Studio (Composer, Director) then re-install as necessary, or
       change association with XVL files using the tool described later.

    2. Do not upgrade or install older versions in an environment where new 
       versions are already installed.

       In such cases, first uninstall the program by following the 
       instructions outlined below in "*UNINSTALLING", then reinstall the old
       version.  If older versions are installed in an environment where new
       versions are already installed, two programs are shown in the [Control
       Panel]-[Add and Remove Programs] window, although they correspond to 
       the same program.  These two programs can be uninstalled.  Note, 
       however, that uninstalling the second program outputs the message 
       "Unable to self-register", and clicking "OK" completes uninstallation
       normally.

    3. If new and old versions of Lattice3D Studio and Lattice3D Player are 
       mixed,  program associations may cause unexpected results depending on
       the order of installation.

       If an old version of Lattice3D Player is installed in an environment
       where a new version of Lattice3D Studio is installed, or if an old 
       version of Lattice3D Studio is installed in an environment where a new
       version of Lattice3D Player is installed, XVL files will be associated
       with the program installed later.  In this case, uninstall the new 
       version of the program first, then reinstall to associate the program 
       with XVL files.

    4. XVL Studio older than Ver. 10.1 must be uninstalled before installing
       Ver. 10.1b or later.

       The installation program of Ver. 10.1b behaves differently from the
       older one.  Due to this, XVL Studio older than Ver. 10.1 cannot be
       updated to Ver. 10.1b or later.  To install a new version of 
       Lattice3D Studio, delete old XVL Studio by [Add/Remove Programs] in 
       the [Control Panel], then install Ver. 10.1b or newer.

  - Warning upon installation or uninstallation
    In some environments, a warning message may be output upon installation 
    or uninstallation because the following files cannot be self-registered:

    - xvlstudio2_E.exe, xvlsnap.exe
      A warning message is output when the environmental load is high.  
      Installation or uninstallation is completed successfully despite the 
      warning.

    - REAM-studio2.dll
      The system does not satisfy the requirements to use Adobe LiveCycle 
      Rights Management ES encrypted files.  Other functions are used 
      normally despite the warning.

  - Errors upon uninstallation
    In Windows Vista, 7 or 8, when [Programs and Functions] is executed to
    start uninstallation, a message window is shown to urge system reboot.
    In this window, if [Yes.  Reboot now.] is selected to complete 
    uninstallation, the following error message may be output:

      | An error occurred during Lattice3D Studio XXX uninstallation.
      | The program may already be uninstalled.
      |
      | Do you want to delete Lattice3D Studio XXX from the list of
      | [Programs and Functions]?
        "XXX" indicates the grade of Lattice3D Studio.

    Uninstallation is completed successfully despite this error message.

  - License
    The expiration date for use of this software is described in the format 
    "dd-mm-yyyy" in the license file.  Please note that Lattice3D Studio will
     not start once the expiration date has passed.

    A license file that does not contain a character string in the format 
    "dd-mm-yyyy" has no expiry date.


* INSTALLATION

  Note: Installation on Windows 2000/XP requires Administrator privileges.

    Before starting installation, terminate all running applications. If
  applications are running during installation, the installer may prompt 
  the user to close them.

  Executing the installer starts the setup program.  In Windows Vista, 7, or
  8, the [User Account Control] dialog box opens.  Enter the system
  administrator name and password.  Then, follow the on-screen instructions
  to complete installation.

  Run one of the following programs to install Lattice3D Studio:

     Lattice3D_Studio_Corel_Edition-2_0
     Lattice3D_Studio_Corel_Edition_x64-2_0

  The installer should not be renamed, as this may cause unexpected behavior.

  If Lattice3D Studio is already installed, the installer updates the program.

  To use the STEP input option, install XVL Converter Server for STEP.
  For details of how to install XVL Converter Server for STEP, refer
  to XVL_ConvLight_Installation-x_x.pdf, "2.1 Installing XCServer",
  supplied with XVL_ConvLightSTEP-x_x.exe.

  After installation, copy the license file received from the sales 
  representative to activate Lattice3D Studio.  The license files are as 
  follows:


  Follow the procedure below to copy the license file. 

     1. Select [Start]-[All programs]-[Lattice3D Studio XXX]-[License folder],
        where 'XXX' indicates the grade.
        In Windows 8, from the [Start] menu, select [All Applications]-
        [Lattice3D Studio XXX]-[License folder].
        If other Lattice3D products are already installed in Windows 8 
        environment,
        [License folder] may not appear.  In this case, select [Installed
        Lattice3D products]-[License folder].

     2. Copy the license file to the displayed License folder.
        If the license file is copied in Windows Vista, 7 or 8, the [User
        Account Control] dialog box may open.  In that event, enter the
        system administrator name and password, and then perform the
        subsequent operations.

  Lattice3D Studio supports node-locked and floating licenses.

  If Lattice3D Studio maintenance service is valid, Media Access Control 
  (MAC) address of the computers in one office can be changed up to twice a 
  year.


* UNINSTALLING

  To uninstall Lattice3D Studio, open [Control Panel]-[Add / Delete 
  Application].
  Select "Lattice3D Studio XXX" (where 'XXX' indicates the grade) from the 
  application list, and click the Add/Delete button to uninstall the 
  application.

  To uninstall Lattice3D Studio in Windows Vista, 7 or 8, open [Control 
  Panel] - [Uninstall Programs].  Select "Lattice3D Studio XXX" from the
  application list, and click the Uninstall/Change button.  If the [User 
  Account Control] dialog box is shown, enter the system administrator name 
  and password to continue operations.


* ASSOCIATION WITH XVL FILES

  The tool "xvlsetext.exe", provided in the installation folder with the
  installation program, is used to change association with XVL files.

  Only the users who have the administrator privileges can change 
  association with files.  To run the tool in Windows Vista, 7 or 8, execute
  the command from the right-click menu under administrator privileges.

  Starting the tool shows the applications to change association with XVL 
  files.  Check an application with which XVL files are associated and click
  [Apply] or [OK].  The selected application will be associated with XVL 
  files.

  The association with files with extensions xv0, xv2 or xv3 can be changed.


* RESTRICTIONS

  - V-XVL Ver. 10 (U-XVL) files
    Working with V-XVL Ver. 10 (U-XVL) files requires appropriate versions
    of the applications.  For details of products and versions, refer to
    the online manual.

  - Notes on data that include the results of interference checking
    If an XVL file containing interference check results written with the
    following Lattice3D products is read, the results may be
    deleted at the time of reading.

    - Versions of Lattice3D Studio later than the one being used
    - XVL Processor or other Lattice3D products in which XVL Kernel of a 
      version later than the one in the current version is embedded

    For details of the XVL Kernel versions embedded in the corresponding
    products, refer to their copyrights.

    Version numbers with a letter (such as Ver. 8.1b) are regarded as
    equivalent to the version without the letter (such as Ver. 8.1).

    XVL files exported with interference check results must be used in the
    corresponding version of Lattice3D Studio or later.
    Avoid the use of XVL files saved with interference check results using
    one of the above versions of XVL Processor.

  - XVL files containing camera data of clipping planes
    If the location of the near or far clipping plane is fixed in an
    XVL file, the file may not be read in editions of XVL Player older than
    Ver. 8.5a.  For such files, use Lattice3D/XVL Player Ver. 8.5a or higher.
    Note that the near and far clipping plane locations are automatically 
    adjusted in XVL Player Ver. 8.5a.

  - STEP file import/export
    If a STEP file is exported by using XVL Studio older than Ver. 8.0, 
    importing the file in a newer version may fail.  In that event, exporting
    the STEP file again by using XVL Studio Ver. 8.0. may create a correct
    file.


* RESTRICTIONS ON CHARACTER CODES

  - XVL files saved as Unicode is specified in the current version of 
    Lattice3D Studio can be used in the products in which XVL Kernel Ver. 7.7 
    or later is used.  The following are some products that use XVL Kernel 
    7.7 or later:

       - Lattice3D/XVL Player Pro Ver. 12.2 or later
       - Lattice3D/XVL Studio Basic/Standard/Pro Ver. 11.1 or later
       - Lattice3D Reporter Ver. 6.1 or later

  - When Unicode is specified in the current version of Lattice3D Studio as 
    the character code to be used in file saving, the following restrictions
    apply to file saving:

    - If data containing character codes different from those of the current
      OS languages are saved in an XVL file and the file is opened in an old
      version of XVL Studio in which XVL Kernel of versions earlier than
      7.7 is used or in other XVL products, the original text information will
      be converted to another.  Due to this, the element names may be
      duplicated to cause unexpected behavior.  In such cases, correct and
      save the duplicate character strings using a product in which XVL Kernel
      Ver. 7.7 or later is used.  Character strings that may be duplicated
      include "$??$??" (where ? is 0 to 9 or A to F).

    - If XVL files are saved using products in which versions of XVL Kernel
      earlier than 7.7 are used or saved with ANSI set as the character code
      to be used upon file saving, and if an XVL assembly file linked with
      such XVL files is read, specifying Unicode as the character code to be
      used upon file saving and writing only the top XVL assembly file may
      result in a malfunction.  In such cases, save the entire model or save
      the data in a single XVL geometry file.

  - When ANSI is specified in the current version of Lattice3D Studio as the
    character code to be used in file saving, the following restrictions apply
    to file saving:

    - If data contains character codes different from those of the current OS
      languages, the original text information will be converted to another.
      Due to this, the element names may be duplicated to cause unexpected
      behavior.

    - If a model containing assembly or part names with character codes
      different from those of the current OS languages is saved in an XVL
      assembly file, the structure below the corresponding assemblies and
      parts is not read when the saved assembly file is opened.

  - Input characters that are not set with the specified font type 
    may not be shown.  In such cases, specify another font type 
    with which the input characters can be shown.

  - For the functions outlined below in environments where XVL Player Ver.
    12.1a or earlier is installed, XVL files are not shown if their file
    paths are written in character codes different from those of the current
    OS languages, or character strings for notes and other elements may not
    be shown correctly.

    - HTML file writing
    - Event preview

  - Character codes different from those of the current OS languages are 
    invalid for file paths in the following functions:

    - File format specification upon geometry file import:
      - CATIA V4 files
      - IGES files
      - Parasolid files
      - 3DS files
      - DXF files
      - VRML2 files
    - File format specification upon geometry file export:
      - IGES files
      - 3DS files
      - VRML2 files
    - HTML5 file export

  - The following points should be noted when XVL files contain characters of
    languages other than English:

    1. In XVL files containing character data other than English, Japanese
       and Western European languages (Latin-1 character code), a problem 
       has been reported whereby saving process animations and automatic 
       disassembly animations may fail.  
       For simplified Chinese, traditional Chinese and Korean, this problem 
       has been fixed in products using XVL Kernel Ver. 6.15b or later.

    2. Character codes in XVL files have been changed due to the above 
       correction.  Because of this, if XVL files containing simplified 
       Chinese, traditional Chinese or Korean characters are output using 
       current versions of Lattice3D products, the character strings will not
       be handled correctly in XVL products using XVL Kernel Ver. 6.15a or
       older.  The following are some products that use XVL Kernel Ver. 6.15a
       or older (English edition):
       - XVL Web Master Ver. 7.0E or older
       - XVL Notebook Viewer/Basic/Standard Ver. 4.1E or older
       - XVL Player Pro (Ver. 8 or earlier) Ver. 8.5aE or older
       - XVL Player Pro (Ver. 9 or later) Ver. 9.0b2E or older
       - XVL System Toolkit Ver. 2.1aE or older
       - XVL Studio Basic/Standard/Pro Ver. 7.2aE or older
       - Lattice3D Outliner Ver. 2.0E or older
       - Lattice3D Reporter Ver. 2.0aE or older

    3. For XVL products that include character data other than English, 
       Japanese, Western European (Latin-1 character code), simplified 
       Chinese, traditional Chinese and Korean, the problem described in 1 
       above was also reported for products in which versions of XVL Kernel
       older than 7.7 are used.
       These malfunctions have now been fixed for products in which XVL
       Kernel Ver. 7.7 or later is used and multiple languages are enabled.


* RESTRICTIONS ON 64-BIT EDITION

  - Adobe LiveCycle Rights Management ES encrypted files cannot be used.

  - Only single thread operation is available in 64-bit Edition.  Due to
    this, full performance is not obtained for some functions.

  - To use the event preview function, Lattice3D Player 64-bit Edition must 
    be installed.


* KNOWN ISSUES

    - Behavior on Windows 8 tablets
    This product can be used on Windows 8 tablets, but problem-free
    performance is not guaranteed.  The following issues are known:

    - The text size specified for the display must be Medium or Smaller.
      If Larger (regular) is specified, text and menu items will not be shown
      correctly.
    - This product is designed for operation using a mouse and 
      keyboard, and is not completely suited to touch control.  As a result,
      finger- or pen-based selection of menu items may be problematic.      

    Other restrictions apply in usage with Windows 8 tablets.  For more 
    details, please contact your sales agent.

  - Behavior on Windows 8
    The following issue is known:

    - When Intel graphics are installed, this product may not start correctly.
      If this issue arises, upgrade to the latest graphics driver.

  - Behavior in Windows Vista, 7 or 8
    The following problems are already known:

    - When DPI scale is increased, the tolerance of dimensions may not be
      shown correctly.
      >> Reset DPI scale or change the font size of dimensions.
    - When the graphics accelerator is enabled, the view may not be shown 
      immediately after file loading.
      >> Move the window or perform some screen control operations to show
      the view.
    - When the size of the assembly tree panel or the control panel is 
      changed, the view may not be refreshed.
      >> Perform some screen control operations to refresh the view.
    - Text and checkboxes in dialog boxes may not be shown in proper
      positions.
    - Menu titles may not be shown correctly.
    - Files may not be saved correctly in certain directories.
      >> Windows controls access to certain directories such as C:\Windows
      and C:\Program Files.  Files might not be saved correctly to those
      locations.  If that happens, either save the files to another location,
      or use administrator privileges to save the files to those locations.
    - When larger font sizes are used in windows or dialog boxes, the menu bar
      may not be shown correctly.
      >> Reduce the font size specified in Settings of Display Properties on
      the Control Panel.

  - Behavior when multiple instances of Lattice3D Studio are running
    If multiple Lattice3D Studios are running simultaneously, it may not be 
    possible to start another Lattice3D Studio or other Lattice3D application.
    In that event, terminate some of the running instances of Lattice3D 
    Studio.

  - Incorrect dimension difference when the DPI scale is increased
    >> Reset the DPI scale or change the font of dimensions.

  - Problems unique to particular file formats
    - CGM/DXF/EPS/SVG files created for illustration, DXF files created for
      2D DXF data
      In some applications, the files may not be shown correctly.  For 
      details, refer to the online manual.
    - Exported U3D files
      The following restrictions are already confirmed in some applications:
      independent edges in U3D files may not be correctly shown, and camera 
      names may not be correctly shown if they include non-English 
      characters.

  - Problem upon public-key encrypted file reading
    - When the login dialog box is shown, opening a new file or exiting 
      the application results in abnormal termination.  When the login 
      dialog box is open, perform operations only in the dialog box.

  - Acrobat 3D
    When the 3D capturing function is enabled in Acrobat 3D, Lattice3D Studio
    may terminate abnormally or the graphic window may not be correctly shown.
    In that event, disable the 3D capturing function and execute Lattice3D
    Studio.

  - File import in XVL Technical Illustration Suite and XVL Technical
    Collaboration Suite
    - Applying snapshots in scaled data may translate the corresponding
      shapes to another location.
    - If CATIA V5 or Inventor data are read in some environments, XVL
      files output may be larger than before.
    - Cylinder shapes in the files saved by CATIA V5-6R2013 cannot be
      converted correctly.
    - The properties of parts patterned by Creo Parametric cannot be
      converted to respective parts.
    - Shapes in 3D XML dynamic tessellation format cannot be converted
      correctly.

  Although extensive testing has been performed on this version, unexpected
  failure may occur due to the nature of software products. In this event,
  please contact your sales representative.


* RELEASE NOTES

  2014/12/28	Ver. 2.0 release

    <Enhancements and modifications>
    + Files
      - Added the function to enable instance expansion to be flat to bodies
        upon file import.
      - Added the function to enable form file output using Lattice3D
        Reporter functions.
    + Illustration output
      - Added the function to not export coordinate systems to image files.
      - Added the function to export transparent background to image files.
      - Added the function to add snapshot when outputting illustration.
    + Auto update of design change
      - Added the function to add or delete added/deleted parts before/after
        design change.
      - Added the function to update illustration in CorelDESIGNER.
    + Display
      - Enhanced specifications to enable high-quality rendering.
    + Part translation
      - Added the function to enable automatic setting of the base location
        according to the selected elements.
    + Notes
      - Enhanced specifications so that notes created can always be shown at
        a fixed location in the view.
    + Assembly tree
      - Enhanced specifications so that the parameters on the [Shell Display]
        and [Illustration] tabs can be modified when two or more elements are
        selected to open the [Properties] dialog box.
    + Snapshots
      - Added the function to enable creation and display of snapshot
        thumbnails.
    + Disassembly tree
      - Added the function to enable empty disassembly part creation.
    + Annotation view
      - Added the function to enable annotation view refresh.
      - Added the function to enable creation and display of annotation view
        thumbnails.
    + General and others
      - Updated the GUI of the overall application:
        * All toolbars can be customized.
        * The function to hide panels automatically has been added.
        * The method of docking panels and toolbars has been improved.
        * The toolbar buttons shown in the initial status have been changed.
        * The function to show large buttons on toolbars has been added.
      - Added the function to enable definition of shortcut keys.
      - Added the function to enable resetting of the viewpoint, layout and
        visibility to those prevailing upon file import.
      - Added compatibility for the following modes for view control:
        * NX
        * SolidWorks

    <Bug fixes>
    + Files
      - Fixed the problem about no message for opening DXF/DWG file without
        3D data.


  2014/06/18	Ver. 1.0 SP2 release

    <Enhancements and modifications>
    + Files
      - Added the function to import and export PDF files.
      - Enabled application to HTML5 file export for Unicode.
      - Added the function to read 3D PMI and views to the Multi-CAD Direct
        Import option.
    + Illustration output
      - Added the function to enable application of colors to the inside of
        closed outlines for each part.
      - Added the function to specify deletion of small shapes by using the
        illustration size ratio.
      - Added the function to enable deletion of duplicate lines.
    + Cross-sections
      - Added the function to show cross-sections in multiple directions by
        using cutting planes.
      - Added the function to enable cutting of shapes with the cutting plane.
    + Part translation
      - Added the function to enable automatic setting of the base location
        according to the selected elements.
    + Notes
      - Added the function to specify keywords for note character strings to
        reference part properties.
    + Processes
      - Added the function to simplify the display of the [Edit Process
        Animation] tab.
      - Added the function to enable creation of process animations
        automatically in consideration of process order and paths.
    + Annotation view list
      - Added block arrow shapes that can be created.
    + General and others
      - Added the function to enable the use of character strings of multiple
        languages in XVL files.
      - Enabled application to 3D mouse 3Dconnexion.
      - Added the function to enable faster subsequent measurement by caching
        data created for measurement.

    <Bug fixes>
    + Files
      - Fixed the problem whereby IGES file import failed.
      - Fixed the problem whereby SVG file export failed.


  2013/07/26	Ver. 1.0 SP1 release

    <Enhancements and modifications>
    + Files
      - Enabled the Multi-CAD Direct Import option in the 64-bit environment.
      - Enabled the program to send PNG and SVG files to the Corel 
        applications in the 64-bit environment.
    + Illustration output
      - Enhanced specifications so that closed outlines are always created
        for each part.
      - Added [Set View], [Register Viewpoint] and [Apply Viewpoint] to the
        [Illustration] toolbar.
      - Added the function to show the output range frame in the 3D view.
    + General and others
      - Collected the multi-language manuals in the start-up menu into one
        menu item.

    <Bug fixes>
    + Files
      - Fixed the problems about CAD file import.
    + General and others
      - Fixed the problem whereby the installation created empty folders.
      - Fixed the problems about UI messages.


  2013/02/08	Ver. 1.0 release

    2012/06/01    Ver. 11.0a Release
    2012/03/16    Ver. 10.1c Release


* COPYRIGHT NOTICE

  Lattice3D Studio (CAD) Corel Edition Ver. 2.0
  Copyright (C) 2013-2014 Lattice Technology Co.,Ltd. All rights reserved.

  XVL Kernel Ver. 7.10b
  Copyright (C) 1998-2014 Lattice Technology Co.,Ltd. All rights reserved.

  Valkyrie Ver. 7.10b
  Copyright (C) 1998-2014 Lattice Technology Co.,Ltd. & Soji Yamakawa.
  All rights reserved.

  Adobe LiveCycle Rights Management Software
  Copyright (C) 2008 Adobe Systems Incorporated All rights reserved.

  XVLstaff 01-03
  Copyright (C) 2007,2009 Hitachi Software Engineering Co.,Ltd.
  All rights reserved.

  XVL ULOCK DLL 01-03
  All Rights Reserved.
  Copyright (C) 2010,2014,Hitachi Solutions, Ltd.

  NewAsmMngDLL version 5.0.0.4
  Copyright (C) 2001-2011 TOSHIBA Corporation All Rights Reserved.

  Zlib version 1.1.3
  Copyright (C) 1995-1998 Jean-loup Gailly and Mark Adler.
  All rights reserved.

  Xerces-C++ Version 1.3.0
  Copyright (c) 2000 The Apache Software Foundation. All rights reserved.

  The Independent JPEG Group's JPEG software release 6b
  Copyright (C) 1991-1998, Thomas G. Lane. All rights reserved.

  Libpng version 1.2.6 - August 15, 2004
  Copyright (c) 1998-2004 Glenn Randers-Pehrson
  Copyright (c) 1996-1997 Andreas Dilger
  Copyright (c) 1995-1996 Guy Eric Schalnat, Group 42, Inc.

  Libtiff version 3.5.7
  Copyright (c) 1988-1997 Sam Leffler
  Copyright (c) 1991-1997 Silicon Graphics, Inc.
    Permission to use, copy, modify, distribute, and sell this software and
    its documentation for any purpose is hereby granted without fee, provided
    that (i) the above copyright notices and this permission notice appear in
    all copies of the software and related documentation, and (ii) the names
    of Sam Leffler and Silicon Graphics may not be used in any advertising or
    publicity relating to the software without the specific, prior written
    permission of Sam Leffler and Silicon Graphics.

    THE SOFTWARE IS PROVIDED "AS-IS" AND WITHOUT WARRANTY OF ANY KIND,
    EXPRESS, IMPLIED OR OTHERWISE, INCLUDING WITHOUT LIMITATION, ANY
    WARRANTY OF MERCHANTABILITY OR FITNESS FOR A PARTICULAR PURPOSE.

    IN NO EVENT SHALL SAM LEFFLER OR SILICON GRAPHICS BE LIABLE FOR
    ANY SPECIAL, INCIDENTAL, INDIRECT OR CONSEQUENTIAL DAMAGES OF ANY KIND,
    OR ANY DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS,
    WHETHER OR NOT ADVISED OF THE POSSIBILITY OF DAMAGE, AND ON ANY THEORY OF
    LIABILITY, ARISING OUT OF OR IN CONNECTION WITH THE USE OR PERFORMANCE
    OF THIS SOFTWARE.

  OpenSSL 0.9.8za 5 Jun 2014
  Copyright (c) 1998-2011 The OpenSSL Project
  Copyright (c) 1995-1998 Eric A. Young, Tim J. Hudson
  All rights reserved.

  Parasolid V24.1.143
  Copyright 2011 Siemens Product Lifecycle Management Software Inc. All 
  rights reserved.
  This software and related documentation are proprietary to Siemens Product 
  Lifecycle Management Software Inc.

  3D Studio File Toolkit for Release 3
  (C) Copyright 1997 by Autodesk, Inc.

  This application incorporates Teigha(R) software pursuant to a license 
  agreement with Open Design Alliance. Teigha(R) Copyright(c) 2003-2013 by 
  Open Design Alliance. All rights reserved.

* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *!
                                                                          * [image](https://github.com/nalendrasatria76/RumahSakit/assets/115075867/83fe6598-1e3b-4550-b0f0-7b14f2aff39d)

