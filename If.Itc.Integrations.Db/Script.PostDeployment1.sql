use Integration
MERGE INTO Assets AS Target 
USING (VALUES 
('AISMLIS', 'Anti Money Laundering System', 'magnus.hogberg@if.se')
) 
AS Source (AssetCode, AssetName, ResponsibleEmail) 
ON Target.AssetCode = Source.AssetCode
-- update matched rows 
WHEN MATCHED THEN 
UPDATE SET AssetName = Source.AssetName, ResponsibleEmail = Source.ResponsibleEmail
-- insert new rows 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (AssetCode, AssetName, ResponsibleEmail) 
VALUES (Source.AssetCode, Source.AssetName, Source.ResponsibleEmail) 
--delete rows that are in the target but not the source 
WHEN NOT MATCHED BY SOURCE THEN 
DELETE;


MERGE INTO dbo.Protocols AS Target 
USING (VALUES 
('REST', 'Rest service')
) 
AS Source (ProtocolCode, [Description]) 
ON Target.ProtocolCode = Source.ProtocolCode
-- update matched rows 
WHEN MATCHED THEN 
UPDATE SET [Description] = Source.[Description]
-- insert new rows 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (ProtocolCode, [Description]) 
VALUES (Source.ProtocolCode, Source.[Description]) 
--delete rows that are in the target but not the source 
WHEN NOT MATCHED BY SOURCE THEN 
DELETE;