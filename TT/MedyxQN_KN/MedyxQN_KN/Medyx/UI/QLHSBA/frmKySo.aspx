<%@ Page Title="" Language="C#" MasterPageFile="~/AdminCode.master" AutoEventWireup="true"  CodeFile="frmKySo.cs" Inherits="UI_QLHSBA_frmKySo" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">


   <script>
      
       var licenseKey = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0iVVRGLTgiIHN0YW5kYWxvbmU9Im5vIj8+PExpY2Vuc2UgaWQ9IkwwMDEiPjxUZW5QaGFuTWVtPkJrYXZDQSBTaWduZXIgUGx1Z2luPC9UZW5QaGFuTWVtPjxOZ3VvaUNhcD5Ca2F2IENvcnBvcmF0aW9uPC9OZ3VvaUNhcD48RG9uVmlEdW9jQ2FwPlZQIEJhbms8L0RvblZpRHVvY0NhcD48SGFuU3VEdW5nPjxOZ2F5Q2FwPjI3LTA2LTIwMjM8L05nYXlDYXA+PE5nYXlIZXRIYW4+MjctMTItMjAyMzwvTmdheUhldEhhbj48L0hhblN1RHVuZz48UXV5ZW5TdUR1bmc+PFVuZ0R1bmc+KjwvVW5nRHVuZz48TW9kdWxlWE1MPjE8L01vZHVsZVhNTD48TW9kdWxlUERGPjE8L01vZHVsZVBERj48TW9kdWxlQ01TPjE8L01vZHVsZUNNUz48TW9kdWxlT09YTUw+MTwvTW9kdWxlT09YTUw+PE1vZHVsZUNlcnRpZmljYXRlVXRpbHM+MTwvTW9kdWxlQ2VydGlmaWNhdGVVdGlscz48TW9kdWxlSW1wb3J0Q2VydD4xPC9Nb2R1bGVJbXBvcnRDZXJ0PjwvUXV5ZW5TdUR1bmc+PFNpZ25hdHVyZSB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC8wOS94bWxkc2lnIyI+PFNpZ25lZEluZm8+PENhbm9uaWNhbGl6YXRpb25NZXRob2QgQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy9UUi8yMDAxL1JFQy14bWwtYzE0bi0yMDAxMDMxNSNXaXRoQ29tbWVudHMiLz48U2lnbmF0dXJlTWV0aG9kIEFsZ29yaXRobT0iaHR0cDovL3d3dy53My5vcmcvMjAwMC8wOS94bWxkc2lnI3JzYS1zaGExIi8+PFJlZmVyZW5jZSBVUkk9IiI+PFRyYW5zZm9ybXM+PFRyYW5zZm9ybSBBbGdvcml0aG09Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvMDkveG1sZHNpZyNlbnZlbG9wZWQtc2lnbmF0dXJlIi8+PC9UcmFuc2Zvcm1zPjxEaWdlc3RNZXRob2QgQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwLzA5L3htbGRzaWcjc2hhMSIvPjxEaWdlc3RWYWx1ZT5xSWtRM1llZjUxbjVDMERpNHFqZkR4SkJzY3c9PC9EaWdlc3RWYWx1ZT48L1JlZmVyZW5jZT48L1NpZ25lZEluZm8+PFNpZ25hdHVyZVZhbHVlPlY1NVpqTUJqZlVscHkvRi9ud01saW84RnVBU3pSTjNMelBqV2tMNDZFRXVneFBPdXJOVDZuWEoxUm9XRTNhaTJxcFlGMW5MNHEzU0smIzEzOw0KY3FTSGdrRmlmN1M3ekZjdUIyaEh6clpjY2pCMVRoK28yL1NzZkJCbjNtNDE0dnh0QjQxMHlYdWhzMTdPdkUrNEd4OWp4NDZRV28xYSYjMTM7DQpkSmZvdGo5TmdkVGJOSFY1M2FZS1ZQMnRnOTgya1NuR1FTaUtPVWdvZWdXMlgyNVdVa2xZS2xwSzBRekJzNUlKQVdrQkVNZVEwMUlEJiMxMzsNCmdkdldLRzBNZE9rR3RBRXdMSk1CVU9SeHlQdWpScnlqQXc2MVpUUUZBUkVvQnRvWWFQNEpEeEw3MDIrRExoblphTGhoRU5VQW9TQ3EmIzEzOw0KdUVxME00d2F0aUFwSlB0NmsvMFIyaUNic0VDTE5UckE4SVlFN2c9PTwvU2lnbmF0dXJlVmFsdWU+PEtleUluZm8+PFg1MDlEYXRhPjxYNTA5U3ViamVjdE5hbWU+Qz1WTixTVD1Iw6AgTuG7mWksTD1D4bqndSBHaeG6pXksTz1Dw7RuZyB0eSBD4buVIHBo4bqnbiBCa2F2LE9VPUJhbiBBTk0sQ049QmthdkNBIExpY2Vuc2UsVUlEPU1TVDowMTAxMzYwNjk3LUJrYXZDQUxpY2Vuc2U8L1g1MDlTdWJqZWN0TmFtZT48WDUwOUNlcnRpZmljYXRlPk1JSUUxakNDQTc2Z0F3SUJBZ0lRVkFOZ2ZXZGdYMEFWR0h1WUpNNUVyakFOQmdrcWhraUc5dzBCQVFVRkFEQkpNUXN3Q1FZRFZRUUcmIzEzOw0KRXdKV1RqRU9NQXdHQTFVRUJ4TUZTR0Z1YjJreEdUQVhCZ05WQkFvVEVFSnJZWFlnUTI5eWNHOXlZWFJwYjI0eER6QU5CZ05WQkFNVCYjMTM7DQpCa0pyWVhaRFFUQWVGdzB4T0RBNE1Ea3dPRFF3TWpKYUZ3MHlNREExTVRVd016TTFORGhhTUlHMU1Td3dLZ1lLQ1pJbWlaUHlMR1FCJiMxMzsNCkFRd2NUVk5VT2pBeE1ERXpOakEyT1RjdFFtdGhka05CVEdsalpXNXpaVEVYTUJVR0ExVUVBd3dPUW10aGRrTkJJRXhwWTJWdWMyVXgmIzEzOw0KRURBT0JnTlZCQXNNQjBKaGJpQkJUazB4SWpBZ0JnTlZCQW9NR1VQRHRHNW5JSFI1SUVQaHU1VWdjR2podXFkdUlFSnJZWFl4RlRBVCYjMTM7DQpCZ05WQkFjTURFUGh1cWQxSUVkcDRicWxlVEVTTUJBR0ExVUVDQXdKU01PZ0lFN2h1NWxwTVFzd0NRWURWUVFHRXdKV1RqQ0NBU0l3JiMxMzsNCkRRWUpLb1pJaHZjTkFRRUJCUUFEZ2dFUEFEQ0NBUW9DZ2dFQkFQTGRRMmNUZ1k5UmJ5M081R0VZdTdjaDF5UldBU0JXZGNkcVhqYVomIzEzOw0KTGJMYnFFV1lMMFQrQXZBNHFBa3FDQWR3czkwbmVrR1Y2TVo3c1R1KzBLK3IxQS9sUnNBMDhEbUY3My9CQzVtQ0dPZW94bmJDYUFaKyYjMTM7DQpIQ2t5NDRsSVF5QWgwT011UUllSE9PZW8wUkhYOGJWVXozZUJ0ZGJoZmZTVC8zYWIyd09kaVpFYVp6SU5GaFBKZGpITXRibWpYUlAvJiMxMzsNCjVHNXpkMUZ6RUZiRXJMNUVQejdTVzR6S0syYnd6RHJKODlQazBGNm5tU0xOTmRNM0lsZEU2aHBmUVg3eHlwV1ZaTXlyM0N1dEZKS08mIzEzOw0KOTRxcFZSWjJhdW01K0NHZUtXOEh6OTB0N1RPRzVRMThJUHVKdWo5eFRkRlB4Ymhaa00zY09rYW5lTTBxREhsdGhLN1o1aEgzeCtrQyYjMTM7DQpBd0VBQWFPQ0FVc3dnZ0ZITURFR0NDc0dBUVVGQndFQkJDVXdJekFoQmdnckJnRUZCUWN3QVlZVmFIUjBjRG92TDI5amMzQXVZbXRoJiMxMzsNCmRtTmhMblp1TUIwR0ExVWREZ1FXQkJUbUdlVWtHWXlOYkFjYlBFdk4vTEpmK2JSeGxqQU1CZ05WSFJNQkFmOEVBakFBTUI4R0ExVWQmIzEzOw0KSXdRWU1CYUFGQjZ3RDBpWDM5RERaNmRHaER0WU80Z05VNVNHTUg4R0ExVWRId1I0TUhZd2RLQWpvQ0dHSDJoMGRIQTZMeTlqY213dSYjMTM7DQpZbXRoZG1OaExuWnVMMEpyWVhaRFFTNWpjbXlpVGFSTE1Fa3hEekFOQmdOVkJBTU1Ca0pyWVhaRFFURVpNQmNHQTFVRUNnd1FRbXRoJiMxMzsNCmRpQkRiM0p3YjNKaGRHbHZiakVPTUF3R0ExVUVCd3dGU0dGdWIya3hDekFKQmdOVkJBWVRBbFpPTUE0R0ExVWREd0VCL3dRRUF3SUUmIzEzOw0KOERBekJnTlZIU1VFTERBcUJnZ3JCZ0VGQlFjREFRWUlLd1lCQlFVSEF3SUdDQ3NHQVFVRkJ3TUVCZ29yQmdFRUFZSTNDZ01NTUEwRyYjMTM7DQpDU3FHU0liM0RRRUJCUVVBQTRJQkFRQ1NCTndOVW5TaTJ6MUtLK1A1Q3VkZ1NpYktJeklvdmxmMDJhMUhIK1MxZnFUVmdzNTRwV0d3JiMxMzsNCkVGd0FYcGpvYUF1TmQ3aGpHV0xyRUZEcUhKZzZkY1NwYXNWaUN1YUYxNitkSW5TaGF6VjZDVk54NFoxdmx5dUhvMERQckV6RG9VR3MmIzEzOw0KR2dGb3N0dDRyM2Q1Z25Ybkloa0hncmQ3bG1sTzZxMmFaekkzNE1HNmh5WTVXeHpuZ2ZvTTYwbk83Z1Z4cC90Zm9lRTBoRVE0N0FuUCYjMTM7DQpxNDBvd0k0QXlVL3VyNEQza2pDbEttWHIycHV1Szk4ZUxVTWZhVUNlMTJrMlo3d0ROWnc4eFZDbVhRZ09yaEt5ME1kV1RYSzlFcFM3JiMxMzsNCjhUQmRSY2VyNzZuVm9EMWcwbmlzZ2YvQWRsejVWanhmVUl2ZzFaZHN2QUo1d2dyZGhTTFUzZlh2Rlc0TDwvWDUwOUNlcnRpZmljYXRlPjxYNTA5Q2VydGlmaWNhdGU+TUlJRU56Q0NBeCtnQXdJQkFnSUtZUitrMUFBQUFBQUFFVEFOQmdrcWhraUc5dzBCQVFVRkFEQitNUXN3Q1FZRFZRUUdFd0pXVGpFeiYjMTM7DQpNREVHQTFVRUNoTXFUV2x1YVhOMGNua2diMllnU1c1bWIzSnRZWFJwYjI0Z1lXNWtJRU52YlcxMWJtbGpZWFJwYjI1ek1Sc3dHUVlEJiMxMzsNClZRUUxFeEpPWVhScGIyNWhiQ0JEUVNCRFpXNTBaWEl4SFRBYkJnTlZCQU1URkUxSlF5Qk9ZWFJwYjI1aGJDQlNiMjkwSUVOQk1CNFgmIzEzOw0KRFRFNU1EVXhNREEzTlRNd04xb1hEVEkwTURVeE1EQTRNRE13TjFvd1NURUxNQWtHQTFVRUJoTUNWazR4RGpBTUJnTlZCQWNUQlVoaCYjMTM7DQpibTlwTVJrd0Z3WURWUVFLRXhCQ2EyRjJJRU52Y25CdmNtRjBhVzl1TVE4d0RRWURWUVFERXdaQ2EyRjJRMEV3Z2dFaU1BMEdDU3FHJiMxMzsNClNJYjNEUUVCQVFVQUE0SUJEd0F3Z2dFS0FvSUJBUUREall5MkJ6bzVyMzN2bHdZVHA3cXhXeDRkcGZwaXphZjZlUTZ4ekVEUGVSUU4mIzEzOw0Kam1tVzYvUkZnM2QxdHY4a2NTV1d4NktodW1JTHp6WmR2ZkVSWE1rUXBUR3VlcXEzNXpHN2Q5R1Vsa21JVkR5Y1E0Vnd2b3hxOU1UVyYjMTM7DQpObnJRc1luL0FScWl4MXVFMFpPc1lueWMzY2NTaTByS1prZ09yeUJHWFVka211ekhPMVhNazhJR04yQUxoZzBJcjBsWStEZENtNHRlJiMxMzsNCmVhc2Iwc1lkY2JVRHdISlB0ZzFrRUplMVQybVhTd1lDTkhCdjdMZzdpbkMrQVJmeG9DMEFsYUhhWlVQekhIQm1XdHlKUjJXSHd1WXAmIzEzOw0KRE1FNFJtOE5KdTBvZkc3QitOblpncTFzMmFHS1htNGN4NEU5NXhQSm52SzNlNnduanhhQTUvM1hDWmEvR1dRbEJSSTFBZ01CQUFHaiYjMTM7DQpnZXN3Z2Vnd0VnWURWUjBUQVFIL0JBZ3dCZ0VCL3dJQkFEQUxCZ05WSFE4RUJBTUNBWVl3SFFZRFZSME9CQllFRkI2d0QwaVgzOUREJiMxMzsNClo2ZEdoRHRZTzRnTlU1U0dNQjhHQTFVZEl3UVlNQmFBRk0xaWNlUmh2ZjQ5N0xKQVlOT0JkZDA2ckd2R01Ed0dBMVVkSHdRMU1ETXcmIzEzOw0KTWFBdm9DMkdLMmgwZEhBNkx5OXdkV0pzYVdNdWNtOXZkR05oTG1kdmRpNTJiaTlqY213dmJXbGpibkpqWVM1amNtd3dSd1lJS3dZQiYjMTM7DQpCUVVIQVFFRU96QTVNRGNHQ0NzR0FRVUZCekFDaGl0b2RIUndPaTh2Y0hWaWJHbGpMbkp2YjNSallTNW5iM1l1ZG00dlkzSjBMMjFwJiMxMzsNClkyNXlZMkV1WTNKME1BMEdDU3FHU0liM0RRRUJCUVVBQTRJQkFRQkVnb3VHWEY5em1YckpHb0N4UDNYQ2FxdXVLYUZXbnVLMUs2YXYmIzEzOw0Kb1BrelF5cm9xOWo3VVFyMlZ4TlRwQUptZGpSNXZRYUhQRVZqTEVnWWFIejlySEdrL3d1OFU4cTYzeXJQWG02MXorVy9YQm5iOW9EViYjMTM7DQpXeDAwdjgxZThSYkQ3Q3ZiSUp4N3haa1RjbVpxQW14c0d1TjhxRjFsc1RUeHNiNGwvb3JYdkZxYTZnU0dkcTgzY1QzZDdEOXUvQUY5JiMxMzsNCmpxenlNWFpwVVo2d2NRWitsRUVPRGVXSXJwZUdrSGZBWnVkNGE1TkhjYUk3YWw5QUZ3ZVBYU1ZlS2ZxTjdnbEEwWVdCSmFzZzhIWXEmIzEzOw0KN0RxTSs0TzVhTlhTMFFwUE5IRjRBQnhmeTZMVkk0U0RuTHZ3ODgrM2ZtcWV3TDdJWmw3Nm1ablhvWkJZYkkrdy9pZUZiSzd6ZEtWbjwvWDUwOUNlcnRpZmljYXRlPjxYNTA5Q2VydGlmaWNhdGU+TUlJRDF6Q0NBcitnQXdJQkFnSVFHK1J6aWg4K3dJOUhuNmJQTmNXWUlqQU5CZ2txaGtpRzl3MEJBUVVGQURCK01Rc3dDUVlEVlFRRyYjMTM7DQpFd0pXVGpFek1ERUdBMVVFQ2hNcVRXbHVhWE4wY25rZ2IyWWdTVzVtYjNKdFlYUnBiMjRnWVc1a0lFTnZiVzExYm1sallYUnBiMjV6JiMxMzsNCk1Sc3dHUVlEVlFRTEV4Sk9ZWFJwYjI1aGJDQkRRU0JEWlc1MFpYSXhIVEFiQmdOVkJBTVRGRTFKUXlCT1lYUnBiMjVoYkNCU2IyOTAmIzEzOw0KSUVOQk1CNFhEVEE0TURVeE5qQXhNVEkwT1ZvWERUUXdNRFV4TmpBeE1qQXpNbG93ZmpFTE1Ba0dBMVVFQmhNQ1ZrNHhNekF4QmdOViYjMTM7DQpCQW9US2sxcGJtbHpkSEo1SUc5bUlFbHVabTl5YldGMGFXOXVJR0Z1WkNCRGIyMXRkVzVwWTJGMGFXOXVjekViTUJrR0ExVUVDeE1TJiMxMzsNClRtRjBhVzl1WVd3Z1EwRWdRMlZ1ZEdWeU1SMHdHd1lEVlFRREV4Uk5TVU1nVG1GMGFXOXVZV3dnVW05dmRDQkRRVENDQVNJd0RRWUomIzEzOw0KS29aSWh2Y05BUUVCQlFBRGdnRVBBRENDQVFvQ2dnRUJBS0UvV1ZFTy9qRC9ZZHVXZUJTTDIwTThOcjVocjl5MVAyQWUwdzBCUWEzNCYjMTM7DQp5WXBDanNqdE1vWkh4ZjYxOStyV1JEY1FFc05JQ0ZGUXV1Vlg2YzQxeVk0Y2N3bUZNMHpodXppc2pxMjNFd1F1Wm9GWExjejdHdjB1JiMxMzsNCm5JdjlDVUR3WUJlYmNVVnRmZVBiS3RLN210M3J6RjdrQU4vVmJEQ0ZtNzFYZnkzVUpOT0ErK0FvVWI2dzFtRUh6T1dnUitlUmJTK0gmIzEzOw0KV09pMHJjR3hSclBjV2gwNENkbjd0U2VZbmw3ODhmUkkvK2loTy85UU05a21xN0taWXAzTWU4aFNUWjVjUW90dmRINzhsQlBlQ3RMdyYjMTM7DQp0V3I0bGt4UW5PWWhqc0hsbHdGT3paK3dRQmw4RzFsdlhEZ1ptamZhMFlFNUZqTHZnYTJ3SVdzUmw4TEJDTDF2STF3RUQ5TUNBd0VBJiMxMzsNCkFhTlJNRTh3Q3dZRFZSMFBCQVFEQWdHR01BOEdBMVVkRXdFQi93UUZNQU1CQWY4d0hRWURWUjBPQkJZRUZNMWljZVJodmY0OTdMSkEmIzEzOw0KWU5PQmRkMDZyR3ZHTUJBR0NTc0dBUVFCZ2pjVkFRUURBZ0VBTUEwR0NTcUdTSWIzRFFFQkJRVUFBNElCQVFCTW5jMStJeUNBSENqUCYjMTM7DQo4UEhKM3hIS3NtbFRvL0pmRExObG5DOVU0UnhRS3VCVkY4UVh2cWlUVVVhcWh1MGtaQzlQRTQ2d3RCU2NmRU8rTFU1alVtemIxbkFYJiMxMzsNCldVZGJvbHF6eDVaNnRnMzFMUTNaWkRxdjBGUTYwUk5vdHZvNERnWHI0UHd3OTB5YlgrTHVaM3Y0WXVwMHIzSlVUTlQ2WG92czY3Z24mIzEzOw0KZ1N5WWp2ZktvRkdXYzhZWGlmbjBVNWMvVjhQYlZTaEpjMDlLTnlwbmhNVVR2c2JKN2dsSFlyK29zdXA4NVY4azJ6dTRkRFd3NFlXUCYjMTM7DQppcGRJanVkNFo0bkw1YVFDN0Z0WG9ibkhscmZCNmVWZGpwbW1weVdhSGJETzFqdHJNL0srU2VFdDFvZUJ1WGF1cC96TnM4WjJNcTlOJiMxMzsNClVGSnNMUTJ5dmRkUTVkTjFZNTlkelFxWjwvWDUwOUNlcnRpZmljYXRlPjwvWDUwOURhdGE+PC9LZXlJbmZvPjwvU2lnbmF0dXJlPjwvTGljZW5zZT4=";
   </script>




        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/base64.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/bkav-extension-signer-v2.0.1.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/BkavCAPlugin.js"></script>
        <link href="../../PDF%20-%20Plugin%20Web%20Demo_files/bootstrap.css" rel="stylesheet" />
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/bootstrap.js"></script>
        <link href="../../PDF%20-%20Plugin%20Web%20Demo_files/bootstrap.vertical-tabs.css" rel="stylesheet" />
        <link href="../../PDF%20-%20Plugin%20Web%20Demo_files/bootstrap.vertical-tabs.min.css" rel="stylesheet" />
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/CertUtils.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/CheckBrowser.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/CheckPluginValid.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/CheckResult.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/jquery-1.10.2.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/jquery-1.10.2.min.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/jquery.xml2json.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/modernizr-2.6.2.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/PDF.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/respond.js"></script>
        <link href="../../PDF%20-%20Plugin%20Web%20Demo_files/site.css" rel="stylesheet" />
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/Utils.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/verify.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/XML.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/xml2json.js"></script>
        <script src="../../PDF%20-%20Plugin%20Web%20Demo_files/xml2json.min.js"></script>



        <style type="text/css">
            body {
                padding: 0;
                margin: 0;

            }
            .mainContent {
              width:100%!important;
          }
            select {
             margin-top:10px;

            }
            .textpdf {
           /*   display: none !important;*/
                width: 97%;
                height : 550px;
            }
            .textshow{
                    display: none !important;
            }
            input{
                margin-bottom: 10px;
            }
            select{
                margin-bottom: 10px;
                  margin-top: 10px;
            }
            button{
                margin-right: 12px !important;
                margin-bottom: 10px !important;
                margin-left: 15px !important;
             }
              
            }
          
            .input{
                  margin-right: auto;
            }
            
            
        </style>
    </telerik:RadCodeBlock>

    
  
<script>
    function SignPDFCallback(data) {
        var decodedata = base64.decode(data);
        var iRet = parseInt(decodedata);

        var dataRet;
        switch (iRet) {
            case 0:
                dataRet = "Không có quyền sử dụng chức năng này";
                alert("Không có quyền sử dụng chức năng này");
                break;
            case 1:
                // alert("Ký thành công");
                break;
            case 2:
                dataRet = "Ký lỗi: Dữ liệu đã được ký";
                alert("Ký lỗi: Dữ liệu đã được ký");
                break;
            case 3:
                dataRet = "Không tìm thấy chứng thư số";
                alert("Không tìm thấy chứng thư số");
                break;
            case 4:
                dataRet = "Dữ liệu đầu vào không đúng định dạng";
                alert("Dữ liệu đầu vào không đúng định dạng");
                break;
            case 5:
                dataRet = "Có lỗi trong quá trình ký";
                alert("Có lỗi trong quá trình ký");
                break;
            case 6:
                dataRet = "Có lỗi trong quá trình lưu chữ ký";
                alert("Có lỗi trong quá trình lưu chữ ký");
                break;
            case 13:
                dataRet = "Người dùng hủy bỏ";
                alert("Người dùng hủy bỏ");
                break;
            default:
                dataRet = data;
                   alert("Ký thành công");
                break;
        }

        var resultSplit = dataRet.split('*');
        document.getElementById('<%= SigningResult.ClientID %>').value = resultSplit[0];
        i++;
        var xmlIn = document.getElementById('<%= pdfPath.ClientID %>').value;
        var serial = document.getElementById('selectCertSerial').value.substring("Số serial: ".length, document.getElementById('selectCertSerial').value.length);
       

    }

    // ký
    function SignBase64PDF() {
        var xmlFileIn = document.getElementById('<%= pdfPath.ClientID %>').value;
        var serial = document.getElementById('selectCertSerial').value.substring("Số serial: ".length, document.getElementById('selectCertSerial').value.length);

        // var fileName = xmlFileIn.split('.').pop();
        // xmlFileOut = xmlFileIn.substring(0, xmlFileIn.length - fileName.length - 1) + '_signed.pdf';
        var signername1 = document.getElementById('selectCert').value;
        // var urlIcon = document.getElementById('urlIcon').value;
        //  var offsetX = document.getElementById('offsetX').value;
        // var offsetY = document.getElementById('offsetY').value;
        SignPDF(xmlFileIn, "", serial, signername1, "", "0", "0", "1", SignPDFCallback);

    }

    function Base64Decode() {
        var dataDecode = document.getElementById('xmlEncode').value;
        document.getElementById('xmlEncodeResult').value = base64.decode(dataDecode);

    }

    // hàm trả về kết quả sau khi verify
    function VerifyPDFBase64Callback(data) {
        var iRet = parseInt(data);
        CheckVerifyResult(iRet);
    }
    // hàm lấy giá trị verify
    function VerifyBase64PDF() {
        var pdfIn = document.getElementById('pdfVerifyPath').value; 
        VerifyPDF(pdfIn, VerifyPDFBase64Callback);
    }

    function GetSysConfigCallback(data) {
        var iRet = data;
        var resultSplit = data.split('*');
        document.getElementById('SystemConfig').value = "Host name: " + resultSplit[0] + "; Mac: " + resultSplit[1] + "; IP: " + resultSplit[2];
    }
    function GetSysConfigWindows() {
        BkavCAPlugin.GetSysConfig(GetSysConfigCallback);
    }
    function LogoutToken() {

        BkavCAPlugin.LogoutSession();
    }

    function CheckPluginGetCert(data) {
        switch (data) {
            case "0":
                alert("Plugin chưa được cài đặt!");
                break;
            case "1":
                GetCertListByFilter(GetCertResult);

                break;
            default:
                alert("Có lỗi trong việc xác thực Plugin!");
                break;
        }
    }

</script>



    <script> CheckPluginValid(CheckPluginGetCert);

        console.log(CheckPluginGetCert);

    </script>

    <telerik:RadToolBar ID="baraction" runat="server" EnableRoundedCorners="true" EnableShadows="true" Width="100%" Style="display: none">
        <Items>
            <%--            <telerik:RadToolBarButton ImageUrl="~/img/icon/add.gif" Text="Thêm nghề nghiệp" Group="Align" CheckOnClick="false" Value="cmdAdd" CommandName="cmdAdd">
            </telerik:RadToolBarButton>--%>
        </Items>
    </telerik:RadToolBar>

    <div>
        <td>
            <asp:Label ID="Label1" runat="server" Text="" Font-Size="40px"></asp:Label>
        </td>
        <table class="input" style="width:100%!important;" >
            <tr>
                <td style="width:40%!important;">
                    <asp:Label ID="Label15" runat="server" Style="font-size: 22px ;margin-left: 200px" Text="PDF Cần Ký"></asp:Label>
                </td>
                <td style="width:20%!important;">
                <asp:Label ID="Label40" runat="server" Style="font-size: 22px ; margin-left: 36px"  Text="Tên Chứng Thư"> </asp:Label></td>
            <td style="width:39%!important;">
                            <asp:Label   ID="Label5" runat="server" Style="font-size: 22px ; margin-left: 230px" Text="PDF Đã Ký"></asp:Label>
                        </td>
                        
                </tr>
            <tr>
                
                 <td>
                   <%-- <textarea id="Textarea1" cols="1" rows="32" placeholder="Dữ liệu cần ký" runat="server" class="textshow" ></textarea>
                    --%>
                     <textarea id="pdfPath" cols="1" rows="6" placeholder="Dữ liệu cần ký" runat="server" class="textpdf"></textarea>
                </td>
                <td>
                    <table>
                        
                        <tr><td><select style="height: 35px !important;" id="selectCert" onchange="selectChange()" class="form-control" name="size">
                    <option value="">Chọn chứng thư số</option>
                </select></td></tr>
                        <tr><td><input id="selectCertIssuer" type="text" class="form-control text-custom" placeholder="Tên Chứng Thư:" aria-describedby="sizing-addon2" readonly="readonly" />
                </td></tr>
                        <tr><td><input id="selectCertSerial" type="text" class="form-control text-custom" placeholder="Số serial của chứng thSignBase64PDFscribedby"="sizinSignBase64XMLdonly"="readonly" />
                </td></tr>
                        <tr><td><input id="selectCertExpire" type="text" class="form-control" placeholder="Hạn sử dụng" aria-describedby="sizing-addon2" readonly="readonly" />
                    </td></tr>
                        <tr><td>
                           
                            <button  id="btnSier"   onclick="event.preventDefault();SignBase64PDF();" runat="server"  class ="btn btn-primary" >  Ký  </button>
                            <button  id="btnSign1" onserverclick="btnSign_Click" runat="server"  class ="btn btn-primary" >Lưu</button>
                            <button  id="Button1" onserverclick="btnEXIT_Click" runat="server" class ="btn btn-primary" >Thoát</button>
                            <%--<button  id="Button2" onserverclick="btnBHXH_Click" runat="server" class ="btn btn-primary"><img src="https://scontent.fhan17-1.fna.fbcdn.net/v/t1.15752-9/367801277_1351143492165834_8618000479672373853_n.png?stp=cp0_dst-png&_nc_cat=109&ccb=1-7&_nc_sid=ae9488&_nc_ohc=hFk1LaG4kwsAX8sXg9x&_nc_ht=scontent.fhan17-1.fna&oh=03_AdT-HNWJ-MVsqQPqFH4OfO0yDPztH9Ul8wswqLLHP282iA&oe=650B8FE6"/>BHXH</button>--%>
                       
                        </td></tr>
                    </table>
                    </td>
                <td>
                            <textarea cols="1" id="SigningResult" rows="32" class="textpdf"  placeholder=""  runat="server" onchange="Change"></textarea>
                          <textarea cols="1" class="textshow" id="savecf" rows="32" placeholder=""  runat="server" onchange="Change"></textarea>
                   
                  

                    </td>
                 
            </tr>
            </table>
    </div>


</asp:Content>

